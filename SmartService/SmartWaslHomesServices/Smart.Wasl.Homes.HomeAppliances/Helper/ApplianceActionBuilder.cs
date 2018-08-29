using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Sprache;
using Smart.Wasl.Homes.Services.HomeAppliances.Domain;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Helper
{
    using UpdateApplianceStateConfiguration = Func<ApplianceStateConfiguration, ApplianceStateConfiguration>;

    public static class ApplianceActionBuilder
    {
        public static Parser<string> Text = Parse.CharExcept(';').Many().Text();
        public static Parser<ushort> Number = Parse.Number.Select(ushort.Parse);
        public static Parser<Decimal> Decimal = Parse.Number.Select(Decimal.Parse);
        public static Parser<PowerState> PowerState = EnumParser<PowerState>.Create();
        public static Parser<VolumeState> VolumeState = EnumParser<VolumeState>.Create();
        public static Parser<CurrentState> CurrentState = EnumParser<CurrentState>.Create();

        public static Parser<bool> Bool = (Sprache.Parse.IgnoreCase("true").Or(Parse.IgnoreCase("false"))).Text().
            Select(x => x.ToLower() == "true");
               
        public static Parser<UpdateApplianceStateConfiguration> Part = new List<Parser<UpdateApplianceStateConfiguration>>
        {
            BuildKeyValueParser("Power", PowerState, c => c.Power),
            BuildKeyValueParser("Volume", VolumeState, c => c.Volume),
            BuildKeyValueParser("CurrentState", CurrentState, c => c.CurrentState),
            BuildKeyValueParser("VolumeValuue", Decimal, c => c.VolumeValuue),
            BuildKeyValueParser("TimerValue", Decimal, c => c.TimerValue)


        }.Aggregate((a, b) => a.Or(b));

        public static Parser<UpdateApplianceStateConfiguration> BuildKeyValueParser<T>(
                 string keyName,
                 Parser<T> valueParser,
                 Expression<Func<ApplianceStateConfiguration, T>> getter)
        {
            return
                from key in Parse.IgnoreCase(keyName).Token()
                from separator in Parse.Char('=')
                from value in valueParser
                select (Func<ApplianceStateConfiguration, ApplianceStateConfiguration>)(c =>
                {
                    CreateSetter(getter)(c, value);
                    return c;
                });
        }
        public static Parser<IEnumerable<UpdateApplianceStateConfiguration>> ConnectionStringBuilder = Part.ListDelimitedBy(';');
        public static Parser<IEnumerable<T>> ListDelimitedBy<T>(this Parser<T> parser, char delimiter)
        {
            return
                from head in parser
                from tail in Parse.Char(delimiter).Then(_ => parser).Many()
                select head.Cons(tail);
        }
        public static Action<ApplianceStateConfiguration, T> CreateSetter<T>(Expression<Func<ApplianceStateConfiguration, T>> getter)
        {
            return CreateSetter<ApplianceStateConfiguration, T>(getter);
        }
        public static Action<TContaining, TProperty> CreateSetter<TContaining, TProperty>(Expression<Func<TContaining, TProperty>> getter)
        {
            Preconditions.CheckNotNull(getter, "getter");

            var memberEx = getter.Body as MemberExpression;

            Preconditions.CheckNotNull(memberEx, "getter", "Body is not a member-expression.");

            var property = memberEx.Member as PropertyInfo;

            Preconditions.CheckNotNull(property, "getter", "Member is not a property.");
            Preconditions.CheckTrue(property.CanWrite, "getter", "Member is not a writeable property.");

#if !NETFX
            return (Action<TContaining, TProperty>)property.GetSetMethod().CreateDelegate(typeof(Action<TContaining, TProperty>));

#else
            return (Action<TContaining, TProperty>)
                Delegate.CreateDelegate(typeof(Action<TContaining, TProperty>),
                    property.GetSetMethod());
#endif

        }

        public static IEnumerable<T> Cons<T>(this T head, IEnumerable<T> rest)
        {
            yield return head;
            foreach (var item in rest)
                yield return item;
        }
        public static class EnumParser<T>
        {
            public static Parser<T> Create()
            {
                var names = Enum.GetNames(typeof(T));

                var parser = Parse.IgnoreCase(names.First()).Token()
                    .Return((T)Enum.Parse(typeof(T), names.First()));

                foreach (var name in names.Skip(1))
                {
                    parser = parser.Or(Parse.IgnoreCase(name).Token().Return((T)Enum.Parse(typeof(T), name)));
                }

                return parser;
            }
        }
    }

}
