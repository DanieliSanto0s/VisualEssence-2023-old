using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Tcc.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do usuário!")]

        public string? NomeResp { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do usuário!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "O email informado é valido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe a senha!")]
        public string? Senha { get; set; }

        public bool IsAdmin { get; set; } = false;

        internal static Task GetUserAsync(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
