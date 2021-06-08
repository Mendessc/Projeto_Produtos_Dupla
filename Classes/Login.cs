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
        bool CadastroConcluido = false;

        Usuario usuario = new Usuario();
        
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
            if (Email != EmailU && Senha != SenhaU)
            {
                Console.WriteLine("As credenciais não estão corretas");
                
            }
            else
            {
                Console.WriteLine("Zika do pantano");      
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
                        Usuario u = new Usuario(CodigoCadastro, NomeCadastro, EmailCadastro, SenhaCadastro);
                        usuario.Cadastrar(u);
                        CadastroConcluido = true;

                        break;
                    case "3":
                        Console.WriteLine("Obrigado por utilizar o sistema!");
                        CadastroConcluido = false;
                        break;
                    default:
                        Console.WriteLine("A opção digitada está errada, tente novamente!");
                        break;
                }

            } while (LoginIncorreto == true || CadastroConcluido);
        }
    }
}