using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_28._05.models
{
    public class Login
    {
        // ==========================
        // INTERFACE LOGIN
        // ==========================
        public interface IAutenticacao
        {
            bool Login(string usuario, string senha);
        }

        // ==========================
        // CLASSE ABSTRATA
        // ==========================
        public abstract class PessoaSistema
        {
            public string Nome { get; set; }
            public string Email { get; set; }

            public PessoaSistema(string nome, string email)
            {
                Nome = nome;
                Email = email;
            }

            public abstract void ExibirPermissao();
        }

        // ==========================
        // ADMIN
        // ==========================
        public class Admin : PessoaSistema, IAutenticacao
        {
            public Admin(string nome, string email)
                : base(nome, email)
            {
            }

            public bool Login(string usuario, string senha)
            {
                return usuario == "admin" &&
                       senha == "123";
            }

            public override void ExibirPermissao()
            {
                Console.WriteLine(
                    $"{Nome}: acesso TOTAL ao sistema.");
            }
        }

        // ==========================
        // USUÁRIO COMUM
        // ==========================
        public class UsuarioComum :
            PessoaSistema, IAutenticacao
        {
            public UsuarioComum(
                string nome,
                string email)
                : base(nome, email)
            {
            }

            public bool Login(
                string usuario,
                string senha)
            {
                return usuario == "user" &&
                       senha == "123";
            }

            public override void ExibirPermissao()
            {
                Console.WriteLine(
                    $"{Nome}: acesso LIMITADO.");
            }
        }
    }
}