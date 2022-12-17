using AutoMapper;
using Restaurant.ProductAPI.Models;
using Restaurant.ProductAPI.Models.Dtos;

namespace Restaurant.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(conf => 
            {
                conf.CreateMap<ProductDto, Product>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
