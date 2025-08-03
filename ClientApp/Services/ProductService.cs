using InventoryHub.Shared.DTOs;
using System.Net.Http.Json;
using System.Text.Json;

namespace ClientApp.Services
{
    public class ProductService
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _jsonOptions;

        public ProductService(IHttpClientFactory factory)
        {
            _http = factory.CreateClient(nameof(ProductService));
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<ProductDto>>("/api/products", _jsonOptions)
                       ?? new List<ProductDto>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching products: {ex.Message}");
                return new List<ProductDto>();
            }
        }

        public async Task<ProductDto?> CreateProductAsync(ProductDto dto)
        {
            try
            {
                var response = await _http.PostAsJsonAsync("/api/products", dto);
                return await response.Content.ReadFromJsonAsync<ProductDto>(_jsonOptions);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating product: {ex.Message}");
                return null;
            }
        }

        public async Task<ProductDto?> UpdateProductAsync(int id, ProductDto dto)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"/api/products/{id}", dto);
                return await response.Content.ReadFromJsonAsync<ProductDto>(_jsonOptions);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating product: {ex.Message}");
                return null;
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            try
            {
                await _http.DeleteAsync($"/api/products/{id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting product: {ex.Message}");
            }
        }
    }
}