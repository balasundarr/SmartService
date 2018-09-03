using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Clients.Core.Services.Settings
{
    public interface ISuggestionService
    {
        Task<ObservableCollection<Models.Suggestion>> GetSuggestionsAsync(double latitude, double longitude);
    }
}