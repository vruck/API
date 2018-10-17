using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProdutosRepositorio
    {
        public List<produtos> listar() {
            List<produtos> lista = null;
            using (AppBurguerPigEntities db =
                new AppBurguerPigEntities())
            {
                lista = (from p in db.produtos
                         orderby p.descricao
                         select p).ToList();
            }
            return lista;
        }


        public produtos GetProduto(int codigo) {
            produtos pro = null;
            using (AppBurguerPigEntities db =
                new AppBurguerPigEntities())
            {
                pro = (from p in db.produtos
                       where p.codigo ==codigo
                       select p).FirstOrDefault();
            }
            return pro;
        }

        public void inserir(produtos pro) {
            using (AppBurguerPigEntities db = 
                new AppBurguerPigEntities())
            {
                db.produtos.Add(pro);
                db.SaveChanges();
            }
        }

        public void alterar(produtos pro)
        {
            using (AppBurguerPigEntities db =
                new AppBurguerPigEntities())
            {
                db.Entry(pro).State = 
                 System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(produtos pro)
        {
            using (AppBurguerPigEntities db =
                new AppBurguerPigEntities())
            {
                db.Entry(pro).State =
                 System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
