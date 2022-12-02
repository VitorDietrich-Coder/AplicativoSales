using Sales.Models.Enums;
using System;

namespace Sales.Models
{
    public class RecordeVendas
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public Double quantidade { get; set; }
        public StatusVendas status { get; set; }
        public Vendedores vendedores { get; set; }

        public RecordeVendas()
        { 
        }

        public RecordeVendas(int id, DateTime data, double quantidade, StatusVendas status, Vendedores vendedores)
        {
            this.id = id;
            this.data = data;
            this.quantidade = quantidade;
            this.status = status;
            this.vendedores = vendedores;
        }
    }
}
