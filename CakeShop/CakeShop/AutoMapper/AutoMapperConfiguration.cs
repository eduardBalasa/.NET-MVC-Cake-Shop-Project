using AutoMapper;

namespace CakeShop.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            // Create Automapper profiles
            Mapper.Initialize(m =>
            {
                m.AddProfile<DomainToViewModelMappingProfile>();
                m.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
