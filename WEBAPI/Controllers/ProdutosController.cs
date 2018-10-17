using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repositorio;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class ProdutosController : ApiController
    {
        [HttpGet]
        [AcceptVerbs("GET")]
        public List<ProdutosModel> listar() {
            //List<produtos> lista= 
            //    (new ProdutosRepositorio()).listar();
            //List<ProdutosModel> listaModel = 
            //    AutoMapper.Mapper.Map<List<produtos>,
            //    List<ProdutosModel>>(lista);
            //return listaModel;
            return AutoMapper.Mapper.Map<List<produtos>,
                List<ProdutosModel>>
                ((new ProdutosRepositorio()).listar());
        }

        [HttpGet]
        [AcceptVerbs("GET")]
        public ProdutosModel GetProduto(int id) {
            return AutoMapper.Mapper.Map<
                produtos, ProdutosModel>((
                new ProdutosRepositorio()).GetProduto(id));
        }


        [HttpPost]
        [AcceptVerbs("POST")]
        public void inserir(ProdutosModel model) {
            produtos pro =
                AutoMapper.Mapper.Map<ProdutosModel, produtos>(model);
            (new ProdutosRepositorio()).inserir(pro);

        }


        [HttpPut]
        [AcceptVerbs("PUT")]
        public void alterar(ProdutosModel model)
        {
            produtos pro =
                AutoMapper.Mapper.Map<ProdutosModel, produtos>(model);
            (new ProdutosRepositorio()).alterar(pro);

        }


        [HttpDelete]
        [AcceptVerbs("DELETE")]
        public void excluir(ProdutosModel model)
        {
            produtos pro =
                AutoMapper.Mapper.Map<ProdutosModel, produtos>(model);
            (new ProdutosRepositorio()).excluir(pro);

        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        public void excluir(int id)
        {

            produtos pro = 
                (new ProdutosRepositorio()).GetProduto(id);
            (new ProdutosRepositorio()).excluir(pro);

        }

    }
}
