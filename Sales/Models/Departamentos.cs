using System;
using System.Collections.Generic;
using System.Linq;
namespace Sales.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedores> vendedores { get; set; } = new List<Vendedores>();

        public Departamentos()
        { 
        }
        public Departamentos(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Vendedores vendedor)
        {
            vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return vendedores.Sum(vendedor => vendedor.TotalVendas(inicial, final));
        }
    }
}
