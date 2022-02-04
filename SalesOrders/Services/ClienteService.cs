using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Models.Enums;
using SalesOrders.Repositories;
using System;

namespace SalesOrders.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ClienteService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Cliente GetID(int id)
        {

            var cliente = _unitOfWork.ClienteRepository.GetID(id);
            return cliente;


        }
        public ActionResult<Cliente> save(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            cliente.Status = ClienteStatus.ATIVO;
            _unitOfWork.ClienteRepository.Add(cliente);
            _unitOfWork.Commit();
            return cliente;
        }

        public ActionResult<bool> verificaCredito(int id)
        {

            var credito = false;
            var cliente = GetID(id);
            if(cliente == null)
            {
                throw new Exception("Cliente não encontrado");
            }

            else if (cliente != null && cliente.LimiteCredito > 0)
            {
                credito = true;
                return credito;
            }
            else 
            {
                return credito;
            }

        }

        // Alterar status cliente
        public Cliente alteraStatus(int id, ClienteStatus status)
        {

            var cliente = GetID(id);
            if (cliente == null)
            {
                throw new Exception("Cliente não encontrado");
            }
            else
            {
                cliente.Status = status;
                _unitOfWork.ClienteRepository.UpdatePartial(cliente);
                _unitOfWork.Commit();
                return cliente;
            }

        }
    }
}
