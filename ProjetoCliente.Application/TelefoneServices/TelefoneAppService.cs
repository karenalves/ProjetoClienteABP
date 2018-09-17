using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using ProjetoCliente.Entities.TelefoneEntity;
using ProjetoCliente.Entities.TelefoneEntity.Manager;
using ProjetoCliente.TelefoneServices.Dtos;

namespace ProjetoCliente.TelefoneServices
{
    public class TelefoneAppService : ITelefoneAppService
    {
        public TelefoneManager _telefoneManager;
        public TelefoneAppService(TelefoneManager telefoneManager)
        {
            this._telefoneManager = telefoneManager;
        }

        public async Task<IdTelefone> CreateTelefone(CreateTelefoneInput input)
        {
            var tel = input.MapTo<Telefone>();

            var idTelCriado = await _telefoneManager.CreateTelefone(tel);

            return new IdTelefone
            {
                Id = idTelCriado
            };
        }

        public async Task DeleteTelefone(long id)
        {
            await _telefoneManager.DeleteTelefone(id);
        }

        public async Task<GetTelefone> GetByIdTelefone(long id)
        {
            return Mapper.Map<GetTelefone>(await _telefoneManager.GetByIdTelefone(id));
        }

        public async Task<GetAllTelefone> GetTelefoneCliente(long idCliente)
        {
            return new GetAllTelefone
            {
                Telefones = Mapper.Map<List<GetTelefone>>(await _telefoneManager.GetTelefoneCliente(idCliente))
            };
        }

        public async Task<GetTelefone> UpdateTelefone(GetTelefone input)
        {
            var tel = input.MapTo<Telefone>();
            return Mapper.Map<GetTelefone>(await _telefoneManager.UpdateTelefone(tel));
        }
    }
}
