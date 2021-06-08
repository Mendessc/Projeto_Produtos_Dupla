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
                        Console.WriteLine(usuario.EmailU);
                        
                        Console.WriteLine(usuario.SenhaU);
                        if (Email != usuario.EmailU && Senha != usuario.SenhaU)
                        {

                            Console.WriteLine("Zika ");
                        }
                        else
                        {
                            Console.WriteLine("Zika do pantano");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Digite seu email: ");
                        string _Email = Console.ReadLine();
                        Console.WriteLine("Digite sua senha: ");
                        string _Senha = Console.ReadLine();
                        Console.WriteLine("Digite seu nome: ");
                        string _Nome = Console.ReadLine();
                        Console.WriteLine("Digite seu código: ");
                        int _Codigo = int.Parse(Console.ReadLine());
                        Usuario u = new Usuario(_Codigo, _Nome, _Email, _Senha);
                        Console.WriteLine(usuario.Cadastrar(u));
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