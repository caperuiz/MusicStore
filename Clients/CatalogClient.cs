using MusicStore.Client.Models;
using System.Net.Http.Json;

namespace MusicStore.Client.Clients
{
    public class CatalogClient
    {
        private readonly HttpClient _httpClient;

        public CatalogClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Catalog[]?> GetAllCatalogsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Catalog[]>("catalogs");
        }
    }
}
