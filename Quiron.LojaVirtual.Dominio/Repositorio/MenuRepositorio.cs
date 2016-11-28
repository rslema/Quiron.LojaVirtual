using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Quiron.LojaVirtual.Dominio.Entidades;



namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class MenuRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Categoria> ObterCategorias()
        {
            return _context.Categorias.OrderBy(c => c.CategoriaDescricao);
        }



       
        }


    }



