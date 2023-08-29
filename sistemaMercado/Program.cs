using sistemaMercado.Propriedades;
using sistemaMercado.Propriedades.Colaboradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sistemaMercado {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("INICIADO");
            Console.WriteLine();

            List<RegistroUsuario> usuarios = new List<RegistroUsuario>();
                // instanciamos a classe usuario

            usuarios.Add(new RegistroUsuario { Nome = "Cadastro Master", Nivel = Usuario.nivelUsuario.Cadastro });
            usuarios.Add(new RegistroUsuario { Nome = "CaixaMaster", Nivel = Usuario.nivelUsuario.Caixa });
               // Adicionamos os dados a lista
            

            Console.WriteLine("Identifique - se digitando sua função!");
            Console.WriteLine();

            Console.WriteLine("Para Cadastro digite 0");
            Console.WriteLine("Para Caixa digite 1");
            Console.WriteLine();

            Console.Write("Nivel: ");
            int entradaNivel = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (entradaNivel)
            {
                case 0:
                    AcessoCadastro acessoCadastro = new AcessoCadastro();
                    acessoCadastro.operacaoCadastro(usuarios);
                       // Deixamos os dados acessíveis na pasta Acesso cadastro
                    break;
            }
        }
    }
}
