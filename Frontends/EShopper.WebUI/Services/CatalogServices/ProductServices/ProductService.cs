using EShopper.WebUI.Dtos.CatalogDtos.ProductDtos;

namespace EShopper.WebUI.Services.CatalogServices.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client)
        {
            _client = client;
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            await _client.PostAsJsonAsync("products", createProductDto);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _client.DeleteAsync("products/" + id);
        }

        public async Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultProductDto>>("products");
        }

        public async Task<ResultProductDto> GetProductByIdAsync(string id)
        {
            return await _client.GetFromJsonAsync<ResultProductDto>("products/" + id);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            await _client.PutAsJsonAsync("products", updateProductDto);
        }
    }
}
