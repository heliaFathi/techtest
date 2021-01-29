using AutoMapper;

namespace TechTest01.Services.Common
{
    public class AutoMapperConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(x => x.AddProfile<GeneralProfile>());
        }
    }
}
