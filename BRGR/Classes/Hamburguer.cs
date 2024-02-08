using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGR.Classes
{
    public class Hamburguer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Ingrediente> Ingredientes = new List<Ingrediente>();
        public double Custo { get; set; }
        public Hamburguer() { }

        public void CalculaCusto()
        {
            double sum = 0;
            foreach (Ingrediente item in Ingredientes)
            {
                sum += item.Custo;
            }
            Custo = sum;
        }

        public override string ToString()
        {
            return Nome.ToString();
        }

        public string ListaIngredientes()
        {
            string ingredientes = string.Empty;
            foreach(Ingrediente ingrediente in Ingredientes)
            {
                ingredientes += ingrediente.Nome + ", ";
            }
            ingredientes.Remove(ingredientes.Length - 1);
            return ingredientes;
        }
    }
}
