﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGR.Classes
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string PrecoTipo { get; set; }
        public double Preco { get; set; }
        public double Unidades { get; set; }
        public double Porcao { get; set; }
        public double PrecoUnitario { get; set; }
        public double Custo { get; set; }

        public Ingrediente() { }

        public void Calculos()
        {
            PrecoUnitario = CalcularPrecoUnitario();
            Custo = CalcularCusto();
        }
        public double CalcularPrecoUnitario()
        {
            if (PrecoTipo == "Preco/Kg")
            {
                return Porcao * Preco / 1000;
            } 
            else
            {
                return Unidades / Preco;
            }
                
        }

        public double CalcularCusto()
        {
            
            if (PrecoTipo == "Preco/Kg")
            {
                return PrecoUnitario * Unidades * 1000;
            } 
            else
            {
                return PrecoUnitario * Porcao;
            }
        }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}