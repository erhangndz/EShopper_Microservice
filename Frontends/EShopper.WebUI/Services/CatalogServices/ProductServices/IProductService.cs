using EShopper.WebUI.Dtos.CatalogDtos.ProductDtos;

namespace EShopper.WebUI.Services.CatalogServices.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();

        Task<ResultProductDto> GetProductByIdAsync(string id);

        Task UpdateProductAsync(UpdateProductDto updateProductDto);

        Task CreateProductAsync(CreateProductDto createProductDto);

        Task DeleteProductAsync(string id);

    }
}
