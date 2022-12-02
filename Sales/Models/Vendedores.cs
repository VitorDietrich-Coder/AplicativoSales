using System;
using System.Collections.Generic;
using System.Linq;

namespace Sales.Models
{
    public class Vendedores
    {
        public int id { get; set; }
        public string nome { get; set; } 
        public string email { get; set; }
        public DateTime dataAniversario { get; set; }
        public double salarioBase { get; set; }
        public Departamentos departamentos { get; set; }
        public ICollection<RecordeVendas> vendas { get; set; } = new List<RecordeVendas>();

        public Vendedores()
        {
        }

        public Vendedores(int id, string nome, string email, DateTime dataAniversario, double salarioBase, Departamentos departamentos)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.dataAniversario = dataAniversario;
            this.salarioBase = salarioBase;
            this.departamentos = departamentos;
        }

        public void AdicionarVenda(RecordeVendas rv)
        {
            vendas.Add(rv);
        }
        public void RemoverVenda(RecordeVendas rv)
        {
            vendas.Remove(rv);
        }
        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return vendas.Where(rv => rv.data >= inicial && rv.data <= final).Sum(rv => rv.quantidade);
        }
    }
}
