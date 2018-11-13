using System.Web.Http;
using Swashbuckle.Application;
using System.Web.Http.Description;
using System;

namespace WebAPI2Swagger
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            var apiExplorer = config.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
            });

            var versionSupportResolver = new Func<ApiDescription, string, bool>((apiDescription, version) => apiDescription.GetGroupName() == version);

            var versionInfoBuilder = new Action<VersionInfoBuilder>(info =>
            {
                foreach (var group in apiExplorer.ApiDescriptions)
                {
                    info.Version(group.Name, $"MyAPI v{group.ApiVersion}");
                }
            });

            config
                .EnableSwagger("{apiVersion}/swagger", c =>
                    {
                        c.MultipleApiVersions(versionSupportResolver, versionInfoBuilder);
                        c.IncludeXmlComments(string.Format(@"{0}\bin\WebAPI2Swagger.xml", System.AppDomain.CurrentDomain.BaseDirectory));
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.EnableDiscoveryUrlSelector();
                        c.DocExpansion(DocExpansion.List);
                    });
        }
    }
}
