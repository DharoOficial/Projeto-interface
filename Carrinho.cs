using System;
using System.IO;
using System.Collections.Generic;
namespace Interface
{
    public class Carrinho : ICarrinho
    {

        List<produto> carrinho = new List<produto>();

        public void alterar(int _codigo, produto produto)
        {
            carrinho.Find(c => c.codigo == _codigo).nome = produto.nome;
            carrinho.Find(c => c.codigo == _codigo).preco = produto.preco;
        }

        public void cadastrar(produto produto)
        {
            carrinho.Add(produto);
        }

        public void deletar(produto produto)
        {
            carrinho.Remove(produto);
        }

        public void listar()
        {
            foreach(produto p in carrinho){
                Console.WriteLine($"Preço: R$ {p.preco}, Nome: {p.nome}");
            }
        }
    }
}