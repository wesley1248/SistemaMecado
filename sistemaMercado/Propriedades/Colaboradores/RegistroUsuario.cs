using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaMercado.Propriedades.Colaboradores {
    internal class RegistroUsuario {
        public string Nome { get; set; }
        public Usuario.nivelUsuario Nivel { get; set; } // No enum é preciso instanciar o nivel tambem.

        public RegistroUsuario() { }

        public RegistroUsuario(string nome, Usuario.nivelUsuario nivel) 
        {
            Nome = nome;
            Nivel = nivel;
        }
    }
}
