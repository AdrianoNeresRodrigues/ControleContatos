using ControleContatos.Enums;
using System.ComponentModel.DataAnnotations;


namespace ControleContatos.Models
{
    public class UsuarioModel
    {
        [Key]
        public int UsuarioId { get; set; }
        public string UsuarioNome { get; set; }
        public string Login { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualização { get; set; }
    }

}
