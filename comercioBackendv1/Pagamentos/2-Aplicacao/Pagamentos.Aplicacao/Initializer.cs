using Microsoft.Extensions.DependencyInjection;
using Pagamentos.Aplicacao.Adapter;
using Pagamentos.Aplicacao.Adapter.Interfaces;
using Pagamentos.Aplicacao.Handles;
using Pagamentos.Aplicacao.Handles.Interfaces;

namespace Pagamentos.Aplicacao
{
    public static class Initializer
    {
        public static void ConfigureIocDI(this IServiceCollection services)
        {
            services.AddScoped<IInserirPagamentoHandle, InserirPagamentoHandle>();
            services.AddScoped<IObterPagamentoHandle, ObterPagamentoHandle>();
            services.AddScoped<IAtualizarPagamentoHandle, AtualizarPagamentoHandle>();
            services.AddScoped<IExcluirPagamentoHandle, ExcluirPagamentoHandle>();
            services.AddScoped<IPagamentosAdapter, PagamentosAdapter>();
        }
    }
}
