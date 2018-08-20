using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO.Modapie
{
    public class InventarioAlxMayor
    {
        //Variables
        /* public int IdLote { get; set; }
         public int EnvioOrden { get; set; }
         public int Codigo { get; set; }
         public string Show { get; set; }
         public string Cliente { get; set; }
         public int Vendedor { get; set; }
         public int Zona { get; set; }
         public string Transporte { get; set; }
         public string Pedido { get; set; }
         public int Modelo { get; set; }
         public int Color { get; set; }
         public string Descripcion { get; set; }
         public string Curva { get; set; }
         public int Pares { get; set; }
         public int Cajas { get; set; }
         public int Cif { get; set; }
         public int TotalCIF { get; set; }
         public int PrecioUnitario { get; set; }
         public int SubTotal { get; set; }
         public int TotalImpuestos { get; set; }
         public Boolean Estado { get; set; }*/

        private int IdLote;
        private int EnvioOrden;
        private int Codigo;
        private string Show;
        private string Cliente;
        private int Vendedor;
        private int Zona;
        private string Transporte;
        private string Pedido;
        private int Modelo;
        private int Color;
        private string Descripcion;
        private string Curva;
        private int Pares;
        private int Cajas;
        private int Cif;
        private int TotalCIF;
        private int PrecioUnitario;
        private int SubTotal;
        private int TotalImpuestos;
        private bool Estado;
        //Constructor
         public InventarioAlxMayor(int Id, int Envio,int codigo, string show, string cliente, int vende, int zona, string transp, string ped, int mod, int col,
              string desc, string curva, int par, int caj, int cif, int tcif, int precU, int subT, int totImp, bool est)
          {
              this.IdLote = Id;
              this.EnvioOrden = Envio;
              this.Codigo = codigo;
              this.Show = show;
              this.Cliente = cliente;
              this.Vendedor = vende;
              this.Zona = zona;
              this.Transporte = transp;
              this.Pedido = ped;
              this.Modelo = mod;
              this.Color = col;
              this.Descripcion = desc;
              this.Curva = curva;
              this.Pares = par;
              this.Cajas = caj;
              this.Cif = cif;
              this.TotalCIF = tcif;
              this.PrecioUnitario = precU;
              this.SubTotal = subT;
              this.TotalImpuestos = totImp;
              this.Estado = est;
          }

          public InventarioAlxMayor()
          { }

          //Set Y Get
          public int IdLote1 { get => IdLote; set => IdLote = value; }
          public int EnvioOrden1 { get => EnvioOrden; set => EnvioOrden = value; }
          public string Show1 { get => Show; set => Show = value; }
          public string Cliente1 { get => Cliente; set => Cliente = value; }
          public int Vendedor1 { get => Vendedor; set => Vendedor = value; }
          public int Zona1 { get => Zona; set => Zona = value; }
          public string Transporte1 { get => Transporte; set => Transporte = value; }
          public string Pedido1 { get => Pedido; set => Pedido = value; }
          public int Modelo1 { get => Modelo; set => Modelo = value; }
          public int Color1 { get => Color; set => Color = value; }
          public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
          public string Curva1 { get => Curva; set => Curva = value; }
          public int Pares1 { get => Pares; set => Pares = value; }
          public int Cajas1 { get => Cajas; set => Cajas = value; }
          public int Cif1 { get => Cif; set => Cif = value; }
          public int TotalCIF1 { get => TotalCIF; set => TotalCIF = value; }
          public int PrecioUnitario1 { get => PrecioUnitario; set => PrecioUnitario = value; }
          public int SubTotal1 { get => SubTotal; set => SubTotal = value; }
          public int TotalImpuestos1 { get => TotalImpuestos; set => TotalImpuestos = value; }
          public int Codigo1 { get => Codigo; set => Codigo = value; }
          public bool Estado1 { get => Estado; set => Estado = value; }
    }
}
