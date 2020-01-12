using AutoMapper;
using CakeShop.Models;
using CakeShop.ViewModels;

namespace CakeShop.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        public DomainToViewModelMappingProfile()
        {
            ConfigureMappings();
        }


        /// <summary>
        /// Creates a mapping between source (Domain) and destination (ViewModel)
        /// </summary>
        private void ConfigureMappings()
        {
            CreateMap<Cake, CakeViewModel>().ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name)).ReverseMap();
            CreateMap<Review, ReviewViewModel>().ReverseMap();

        }
    }
}
