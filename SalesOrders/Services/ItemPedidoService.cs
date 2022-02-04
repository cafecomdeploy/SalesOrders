using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SalesOrders.Services
{
    public class ItemPedidoService : IItemPedidoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ItemPedidoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ActionResult<IEnumerable<ItemPedido>> findAll()
        {
            var listaPedido = _unitOfWork.ItemPedidoRepository.GetAll();
            
            return listaPedido;
        }
        public ActionResult<ItemPedido> save(ItemPedidoDTO itemPedidoDTO)
        {
            var itemPedido = _mapper.Map<ItemPedido>(itemPedidoDTO);
            _unitOfWork.ItemPedidoRepository.Add(itemPedido);
            _unitOfWork.Commit();
            return itemPedido;
        }

        public void deleteItem(int id)
        {
            var item = _unitOfWork.ItemPedidoRepository.GetById(i => i.IdItemPedido == id);
            _unitOfWork.ItemPedidoRepository.Delete(item);
            _unitOfWork.Commit();
        }
    }
}
