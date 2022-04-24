
using APP.SubscribeTableDependencies;

namespace APP.MiddlewareExtensions
{
    public static class ApplicationBuilderExtension
    {
        public static void UseSqlTableDependency<T>(this IApplicationBuilder applicationBuilder, string connectionString)
            where T : ISubscribeTableDependency
        {
            //var serviceProvider = applicationBuilder.ApplicationServices;
            //var service = serviceProvider.GetService<T>();
            //service.SubscribeTableDependency(connectionString);

            ///
            var serviceProvider2 = applicationBuilder.ApplicationServices;
            var service2 = serviceProvider2.CreateScope();
            var t = service2.ServiceProvider.GetRequiredService<T>();
            t.SubscribeTableDependency(connectionString);


            //var service1 = serviceProvider.GetService<T>();
            //service.SubscribeTableDependency(connectionString);


        }
    }
}