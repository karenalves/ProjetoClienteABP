using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using ProjetoCliente.ClienteServices.Dtos;
using ProjetoCliente.DocumentoServices.Dtos;
using ProjetoCliente.Entities.ClienteEntity;
using ProjetoCliente.Entities.DocumentoEntity;
using ProjetoCliente.Entities.PedidoEntity;
using ProjetoCliente.Entities.TelefoneEntity;
using ProjetoCliente.PedidoServices.Dtos;
using ProjetoCliente.TelefoneServices.Dtos;

namespace ProjetoCliente
{
    [DependsOn(typeof(ProjetoClienteCoreModule), typeof(AbpAutoMapperModule))]
    public class ProjetoClienteApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateClienteInput, Cliente>()
                .ConstructUsing(x => new Cliente(x.Name, x.Status, x.Documento, x.Telefones));

                config.CreateMap<CreateDocumentoInput, Documento>()
                .ConstructUsing(x => new Documento(x.TipoDocumento, x.NumeroDocumento));

                config.CreateMap<CreatePedidoInput, Pedido>()
                .ConstructUsing(x => new Pedido(x.NomeProduto, x.PrazoEntrega));

                config.CreateMap<CreateTelefoneInput, Telefone>()
                .ConstructUsing(x => new Telefone(x.NumeroTelefone, x.TipoTelefone, x.ClienteId));
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
