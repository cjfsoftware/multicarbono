using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Multicarbono.Models.Cliente;
using Multicarbono.Models.EnderecoCliente;
using Multicarbono.Models.ItemNota;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Login;
using Multicarbono.Models.NotaFiscal;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Produto;
using Multicarbono.Models.Telefone;
using Multicarbono.Models.Transportador;
using Multicarbono.Models.Usuario;
using MySqlConnector;
using Multicarbono.Configuration;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Multicarbono
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddTransient<MySqlConnection>(
               (sp) => new MySqlConnection(Configuration["ConnectionStrings:dbConn"]));

            services.AddSingleton<Security>();

            services.AddTransient<LoginRepository>();
            services.AddTransient<UsuarioRepository>();
            services.AddTransient<TransportadorRepository>();
            services.AddTransient<TelefoneRepository>();
            services.AddTransient<ClienteRepository>();
            services.AddTransient<ProdutoRepository>();
            services.AddTransient<NotaFiscalRepository>();
            services.AddTransient<PedidoRepository>();
            services.AddTransient<EnderecoClienteRepository>();
            services.AddTransient<ItemPedidoRepository>();
            services.AddTransient<ItemNotaRepository>();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
