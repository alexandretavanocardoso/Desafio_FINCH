using Desafio_FINCH.Models;

namespace Desafio_FINCH.Services
{
    public class LoginServices : ILoginServices
    {
        List<User> _userList = new List<User> {
               new User() { Email = "alexandre@outlook.com", Senha = "123456" },
               new User() { Email = "rodrigo@outlook.com", Senha = "123456" },
               new User() { Email = "thales@outlook.com", Senha = "123456" },
               new User() { Email = "lennon@outlook.com", Senha = "123456" },
               new User() { Email = "matheus@outlook.com", Senha = "123456" },
               new User() { Email = "desafio@outlook.com", Senha = "123456" },
               new User() { Email = "finch@outlook.com", Senha = "123456" }
        };

        public LoginServices() { }

        public bool Login(string email, string senha) {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha)) return false;

            foreach (User user in _userList)
                if (email == user.Email && senha == user.Senha) return true;

            return false;
        }
    }
}
