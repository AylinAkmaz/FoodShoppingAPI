using AutoMapper;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.Entity.DTO.FoodDetailDTO;
using FoodShoppingAPI.Entity.DTO.ProductDTO;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;
using FoodShoppingAPI.Entity.Poco;
using FoodShoppingAPI.Entity.Result;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FoodShoppingAPI.API.Controllers
{
    [ApiController]
    [Route("FoodShoppingAPI/[action]")]
    public class ProductController : Controller
	{
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IFoodDetailService _foodDetailService;



        public ProductController(IMapper mapper, IProductService productService, IFoodDetailService foodDetailService)
        {
            _mapper = mapper;
            _productService = productService;
            _foodDetailService = foodDetailService;
        }

        [HttpGet("/Products")]
        [ProducesResponseType(typeof(Sonuç<List<ProductDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAllAsync(q => q.IsActive == true && q.IsDeleted == false, "FoodDetail");
            if (products != null)
            {
                List<ProductDTOResponse> productDtoResponseList = new List<ProductDTOResponse>();
                foreach (var product in products)
                {
                    productDtoResponseList.Add(_mapper.Map<ProductDTOResponse>(product));
                }


                return Ok(Sonuç<List<ProductDTOResponse>>.SuccessWithData(productDtoResponseList));
            }
            else
            {
                return NotFound(Sonuç<List<ProductDTOResponse>>.SuccessNoDataFound());

            }

        }


        [HttpGet("/Product/{guid}")]
        [ProducesResponseType(typeof(Sonuç<List<ProductDTOResponse>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetProductByGUID(Guid guid)
        {
            var product = await _productService.GetAsync(q => q.Guid == guid, "FoodDetail");
            if (product != null)
            {
                ProductDTOResponse productDtoResponse = _mapper.Map<ProductDTOResponse>(product);


                return Ok(Sonuç<ProductDTOResponse>.SuccessWithData(productDtoResponse));
            }
            else
            {
                return NotFound(Sonuç<List<ProductDTOResponse>>.SuccessNoDataFound());

            }

        }




        [HttpPost("/AddProduct")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddProduct(ProductDTORequest productDTORequest)
        {
            var foodDetail = await _foodDetailService.GetAsync(q => q.Guid == productDTORequest.FoodDetailGuid);
         

            Product product = _mapper.Map<Product>(productDTORequest);
            product.FoodDetail = foodDetail;
            


            await _productService.AddAsync(product);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/UpdateProduct")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateProduct(ProductDTOUpdateResponse productDTOUpdateResponse)
        {

            Product product = await _productService.GetAsync(q => q.Guid == productDTOUpdateResponse.Guid);

            var foodDetail = await _productService.GetAsync(q => q.Name == productDTOUpdateResponse.FoodDetailName);
            
            _mapper.Map<Product>(productDTOUpdateResponse);



            await _productService.UpdateAsync(product);

            return Ok(Sonuç<bool>.SuccessWithData(true));
        }



        [HttpPost("/RemoveProduct/{productGuid}")]
        [ProducesResponseType(typeof(Sonuç<bool>), (int)HttpStatusCode.OK)]

        public async Task<IActionResult> RemoveProduct(Guid productGuid)
        {
            Product product = await _productService.GetAsync(q => q.Guid == productGuid);

            product.IsActive = false;
            product.IsDeleted = true;
            await _productService.UpdateAsync(product);
            return Ok(Sonuç<bool>.SuccessWithData(true));
        }




    }
}
