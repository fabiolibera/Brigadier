using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brigadier.LojaVirtual.Dominio.Entidades
{
    public class Produto
    {
        public int     ProdutoId    { get; set; }
        public string  ProdutoName  { get; set; }
        public string  ProdutoDescr { get; set; }
        public decimal ProdutoPreco { get; set; }
        public string  ProdutoCateg { get; set; }
    }
}
