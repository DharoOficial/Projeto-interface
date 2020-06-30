using System;

namespace Interface 
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho car = new Carrinho();

            produto p1 = new produto();
            produto p2 = new produto();
            produto p3 = new produto();
            produto p4 = new produto();
            produto p5 = new produto();

            p1.codigo = 1;
            p1.nome = "RTX 2080";
            p1.preco = 3000f;

            p2.codigo = 2;
            p2.nome = "i9 9900k";
            p2.preco = 3000f;

            p3.codigo = 3;
            p3.nome = "GTX 1080ti";
            p3.preco = 2000f;

            p4.codigo = 4;
            p4.nome = "i3 9100f";
            p4.preco = 600f;
            
            p5.codigo = 5;
            p5.nome = "GTX 1660";
            p5.preco = 1600f;

            car.cadastrar(p1);
            car.cadastrar(p2);
            car.cadastrar(p3);
            car.cadastrar(p4);
            car.listar();

            System.Console.WriteLine("digite o numero do codigo que voce deseja alterar");
            car.alterar(int.Parse(Console.ReadLine())
            , p5);

            car.listar();
        }
    }}
