using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class Entrar
    {
        public List<cadastrar_usuarios> usuarioscliente { get; private set; }
        cadastrar_usuarios cr;
        
        public void entrar()
        {
            Console.WriteLine("digite seu usuario");
            string prim_usuario =Console.ReadLine();
            Console.WriteLine("digite sua senha");
            string senha_usuario=Console.ReadLine();
            if (prim_usuario == cr.usuarioCliente || senha_usuario == cr.senhacliente)
            {
           
            }
            else
            {
                cr = new cadastrar_usuarios();
                usuarioscliente.Add(cr);
            }
            
        }
        


    }
}
