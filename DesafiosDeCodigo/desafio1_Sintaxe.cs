using System;

class Program
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
    string emailCadastro;
    string nomeUsuario;
    string senha;

// Obtém o email e nome do usuário a partir da entrada do console
    emailCadastro = Console.ReadLine();
    nomeUsuario = Console.ReadLine();
    senha = Console.ReadLine();


// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"{nomeUsuario}, verifique o email: {emailCadastro} para ativar." );


    }
}
