using ControleContatos.Models;

namespace ControleContatos.Repositorio
{
    public interface IContatoRepositorio
    {

        bool Apagar(int id);

        //um contrato que vai receber como parametro um objeto contrato
        //e que vai retornar ele mesmo deve ser usado na classe ContatoRepositorio
        //por injeção
        ContatoModel Adicionar(ContatoModel contato);

        List<ContatoModel> BuscarTodos();
        ContatoModel ListarPorId(int Id);

        ContatoModel Atualizar(ContatoModel contato);
    }

}