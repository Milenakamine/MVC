using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista)
        { foreach(Produto item in lista)
                {
                    Console.WriteLine($"{item.Nome} - R${item.Preco}.");
                }
        }
    }
}