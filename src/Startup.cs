using CGQL.NET.Server;
using CGQL.NET.Server.Data;
using CGQL.NET.Server.GraphQL;
using CGQL.NET.Server.GraphQL.DataLoaders;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CGQL.NET.Server
{
    public class Startup
    {
        IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddGraphQLServer()
                .AddQueryType(d => d.Name("Query"))
                    .AddTypeExtension<AddressQuery>()
                    .AddTypeExtension<TransactionQuery>()
                    .AddTypeExtension<BlockQuery>()
                .AddFiltering()
                .AddType<AddressType>()
                .AddType<TransactionType>()
                .AddType<BlockType>()
                .AddType<TransactionMetadataType>();

            services
                .AddPooledDbContextFactory<CardanoDbContext>(options => options.UseNpgsql(Configuration.GetValue<string>("ConnectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
