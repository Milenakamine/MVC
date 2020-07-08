using System;
using MVC.Controllers;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
          ProdutoController produto = new ProdutoController();
          produto.Listar();
        //   produto.Fitrar("4555");
        }
    }
}
