using sistemaMercado.Propriedades.Colaboradores;
using System;
using System.Collections.Generic;

namespace sistemaMercado {
    internal class AcessoCadastro {

        public void operacaoCadastro(List<RegistroUsuario> usuarios) 
            // Recebe a lista Usuario do tipo RegistroUsuario 
        {
            var usuarioMaster = usuarios[0];
               //Usuario máster recebe os dados da lista usuario da posição 0 e exibe logo abaixo

            Console.WriteLine("Usuario: " + usuarioMaster.Nome + ".");
            Console.WriteLine("Nivel: " + usuarioMaster.Nivel + ".");
            Console.WriteLine();

            bool validacaoOperacao = false;
            do
            {
                Console.WriteLine("Encerrar.");
                Console.WriteLine("Cadastrar.");
                Console.WriteLine("Alterar.");
                Console.WriteLine();

                Console.WriteLine("Que operação deseja fazer?: ");
                string entradaOperacao = Console.ReadLine();

                if (entradaOperacao == "encerrar")
                {
                    validacaoOperacao = true;
                }
                else
                {
                    switch (entradaOperacao)
                    {
                        case "cadastrar":

                            break;

                        case "alterar":
                            //operaçao alterar
                            break;
                    }
                }

            } while (!validacaoOperacao);
        }
    }
}
