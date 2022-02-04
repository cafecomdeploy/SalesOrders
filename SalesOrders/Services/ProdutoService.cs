using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Repositories;
using System.Collections.Generic;

namespace SalesOrders.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public ProdutoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ActionResult<IEnumerable<ProdutoDTO>> findAll()
        {
            var produto = _unitOfWork.ProdutoRepository.Get();
            var produtoDTO = _mapper.Map<List<ProdutoDTO>>(produto);
            return produtoDTO;
        }

        public ActionResult<Produto> save(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            _unitOfWork.ProdutoRepository.Add(produto);
            _unitOfWork.Commit();
            return produto;
        }

        public ActionResult<Produto> findById(int id)
        {
            var produto = _unitOfWork.ProdutoRepository.GetById(p => p.IdProduto == id);
            return produto;
        }
    }
}
