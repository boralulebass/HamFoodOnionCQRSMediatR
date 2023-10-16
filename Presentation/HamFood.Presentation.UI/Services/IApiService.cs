namespace HamFood.Presentation.UI.Services
{
    public interface IApiService
    {
        Task<List<T>> GetTableData<T>(string apiUrl);
        Task<T> GetData<T>(string apiUrl);
    }
}
