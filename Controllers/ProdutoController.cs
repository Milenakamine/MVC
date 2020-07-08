using System.Collections.Generic;
using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel= new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){
            //  outro modo
            // List<Produto> produtos= new List<Produto>();
            // produtos = produtoModel.Ler();

            produtoView.MostrarNoConsole(produtoModel.Ler());

        }
        
        public void Fitrar(string _preco){

        List<Produto> lista = new List<Produto>();
        lista = lista.FindAll(x => x.Preco == float.Parse(_preco));
        produtoView.MostrarNoConsole(lista);

        }

    }
}