using AutoMapper;
using CakeShop.BindingModels;
using CakeShop.Models;

namespace CakeShop.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappingProfile";
            }
        }

        public ViewModelToDomainMappingProfile()
        {
            ConfigureMappings();
        }


        /// <summary>
        /// Creates a mapping between source (ViewModel) and destination (Domain)
        /// </summary>
        private void ConfigureMappings()
        {
            CreateMap<CakeBindingModel, Cake>().ReverseMap();
            CreateMap<ReviewBindingModel, Review>().ReverseMap();
            CreateMap<TransactionBindingModel, Transaction>().ReverseMap();

        }
    }
}
