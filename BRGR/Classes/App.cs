using freelaProject.Class.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRGR.Classes
{
    public static class App
    {

        public static List<Ingrediente> ListaIngredientes(string[] fkIngredientes)
        {
            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            foreach (string idIngre in fkIngredientes) 
            {

                if(idIngre != "")
                {
                    dt = connectionsql.getData($"SELECT * FROM tbl_ingredientes WHERE id = '{idIngre}';");

                    int id = int.Parse(dt.Rows[0]["id"].ToString());
                    string nome = dt.Rows[0]["nome"].ToString();
                    string precoTipo = dt.Rows[0]["preco_tipo"].ToString();
                    double preco = double.Parse(dt.Rows[0]["preco"].ToString());
                    double unidades = double.Parse(dt.Rows[0]["unidades"].ToString());
                    double porcao = double.Parse(dt.Rows[0]["porcao"].ToString());

                    Ingrediente ingrediente = new Ingrediente();
                    ingrediente.Nome = nome;
                    ingrediente.Id = id;
                    ingrediente.PrecoTipo = precoTipo;
                    ingrediente.Preco = preco;
                    ingrediente.Unidades = unidades;
                    ingrediente.Porcao = porcao;
                    ingrediente.Calculos();

                    ingredientes.Add(ingrediente);
                }
            }

            return ingredientes;
        }

        public static List<Ingrediente> TodosIngredientes()
        {
            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();

            dt = connectionsql.getData("SELECT * FROM tbl_ingredientes;");

            List<Ingrediente> ingredientes = new List<Ingrediente>();
            foreach(DataRow dr in dt.Rows)
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = int.Parse(dr["id"].ToString());
                ingrediente.Nome = dr["nome"].ToString();
                ingrediente.PrecoTipo = dr["preco_tipo"].ToString();
                ingrediente.Preco = double.Parse(dr["preco"].ToString());
                ingrediente.Unidades = double.Parse(dr["unidades"].ToString());
                ingrediente.Porcao = double.Parse(dr["porcao"].ToString());
                ingrediente.Calculos();

                ingredientes.Add(ingrediente);
            }

            return ingredientes;
        }

    }
}
