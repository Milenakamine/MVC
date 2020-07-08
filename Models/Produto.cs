using System;
using System.Collections.Generic;
using System.IO;

namespace MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }
         

         private const string PATH = "Database/produto.csv";
         public List<Produto> Ler()
         {
            //lista de produtos
            List<Produto> produtos = new List<Produto> ();

            string[] linhas = File.ReadAllLines (PATH);

            foreach (string linha in linhas)
            {

                //separamos os dados de cada linha com Split
                string[] dado = linha.Split (";");

                //produtos que vão ser colocados na lista

                Produto p = new Produto ();
                p.Codigo = Int32.Parse (Separar (dado[0]) );
                p.Nome = Separar (dado[1]);
                p.Preco = float.Parse (Separar (dado[2]) );
                //adicionando os produtos 
                produtos.Add (p);

            }


            return produtos;

        }

         private string Separar (string _coluna) {

            return _coluna.Split ("=") [1];
        }

    }
}