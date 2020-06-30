namespace Interface
{
    public interface ICarrinho
    {
         public void listar();

         public void alterar(int _codigo, produto produto);

         public void cadastrar(produto produto);
         public void deletar(produto produto);
    }
}