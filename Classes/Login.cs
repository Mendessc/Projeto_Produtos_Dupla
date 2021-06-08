using System;
using System.Collections.Generic;
using Projeto_Produtos_Dupla.Interfaces;

namespace Projeto_Produtos_Dupla.Classes
{
    public class Login : Usuario, ILogin
    {
        string Email;
        string Senha;
        bool LoginIncorreto = false;

        Usuario usuario = new Usuario();
        List<Usuario> ListaUsuario = new List<Usuario>();
        public string Deslogar()
        {
            throw new System.NotImplementedException();
        }

        public string Logar()
        {
            
                Console.WriteLine("Digite seu email: ");
                Email = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                Senha = Console.ReadLine();
                if (this.Email != EmailU)
                {
                    Console.WriteLine("O email digitado não está correto");
                    LoginIncorreto = true;

                }
                else if (this.Senha != SenhaU)
                {
                    Console.WriteLine("A senha digitada é incorreta!");
                    LoginIncorreto = true;
                }
                else
                {
                    LoginIncorreto = false;
                }
            

            return "Logado!";
        }

        public void FazerLogin()
        {
            do
            {
                
            Console.WriteLine($@"
Bem vindo! O que deseja fazer?
1 - Fazer Login
2 - Cadastrar Usuario
3 - Sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Logar();
                    break;

                case "2":
                    Console.WriteLine("Digite seu email: ");
                    string EmailCadastro = Console.ReadLine();
                    Console.WriteLine("Digite sua senha: ");
                    string SenhaCadastro = Console.ReadLine();
                    Console.WriteLine("Digite seu nome: ");
                    string NomeCadastro = Console.ReadLine();
                    Console.WriteLine("Digite seu código: ");
                    int CodigoCadastro = int.Parse(Console.ReadLine());

                    
                    break;
                case "3":
                    break;
                default:
                    break;
            }

            } while (LoginIncorreto == true);
        }
    }
}