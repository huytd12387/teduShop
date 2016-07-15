using AutoMapper;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //var config = new MapperConfiguration(cfg =>
            //                                     {
            //                                         cfg.CreateMap<Post, PostViewModel>();
            //                                     });
            //IMapper mapper = config.CreateMapper();
            //mapper.Map<Post, PostViewModel>(new Post());

            //Mapper.Initialize(cfg =>
            //                  {
            //                      cfg.CreateMap<Post, PostViewModel>();
            //                  });
            //Mapper.Map<Post, PostViewModel>(new Post());

            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();

            //Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            //Mapper.CreateMap<Product, ProductViewModel>();
            //Mapper.CreateMap<ProductTag, ProductTagViewModel>();
            //Mapper.CreateMap<Footer, FooterViewModel>();
            //Mapper.CreateMap<Slide, SlideViewModel>();
            //Mapper.CreateMap<Page, PageViewModel>();
            //Mapper.CreateMap<ContactDetail, ContactDetailViewModel>();

            //Mapper.CreateMap<ApplicationGroup, ApplicationGroupViewModel>();
            //Mapper.CreateMap<ApplicationRole, ApplicationRoleViewModel>();
            //Mapper.CreateMap<ApplicationUser, ApplicationUserViewModel>();
        }
    }
}