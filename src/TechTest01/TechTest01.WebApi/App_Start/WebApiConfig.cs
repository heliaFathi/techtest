using AutoMapper;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using TechTest01.Repository;
using TechTest01.Repository.Interfaces;
using TechTest01.Repository.Repositories;
using TechTest01.Services.Common;
using TechTest01.Services.Interfaces;
using TechTest01.Services.Services;
using TechTest01.WebApi.App_Start;
using Unity;

namespace TechTest01.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API configuration and services
            var container = new UnityContainer();

            container.RegisterInstance<IMapper>(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new GeneralProfile());
            }).CreateMapper());

            container.RegisterSingleton<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductsService, ProductsService>();
            config.DependencyResolver = new UnityResolver(container);

            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
