using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Models.Enums;
using SalesOrders.Repositories;
using System.Collections.Generic;

namespace SalesOrders.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PedidoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ActionResult<IEnumerable<Pedido>> findAll()
        {
            return _unitOfWork.PedidoRepository.GetAll();
        }
        public ActionResult<Pedido> save(PedidoDTO pedidoDTO)
        {
             //Transformando DTO em objeto pedido
            var pedido = _mapper.Map<Pedido>(pedidoDTO);
            pedido.Status = PedidoStatus.INICIADO;             
            _unitOfWork.PedidoRepository.Add(pedido);
            _unitOfWork.Commit();
            return pedido;
        }

        public void alteraStatus(int id, PedidoStatus pedidoStatus)
        {
            var pedido = _unitOfWork.PedidoRepository.GetById(p => p.IdPedido == id);
            pedido.Status = pedidoStatus;
            _unitOfWork.PedidoRepository.UpdatePartial(pedido);
            _unitOfWork.Commit();
        }

       
    }
}
