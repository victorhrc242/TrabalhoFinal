using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public  class cadastrar_usuarios
    {

       public string nome { get; set; }
       public string senha { get; set; }
       public string senha2 { get; set; }
        public double cpf { get; set; }
        public int idade { get; set; }
        public int telefone { get; set; }
        public string cidade { get; set; }
        public string banco { get; set; }
        public void cadastrocliente()
        {
            Console.WriteLine("1-Qual o seu Nome de usuario");
             nome=Console.ReadLine();
            Console.WriteLine("2-crie a sua senha");
            senha=Console.ReadLine();
            Console.WriteLine("confirma  a senha que vc inseriu");
             senha2=Console.ReadLine();
            Console.WriteLine("2-Qual o seu cpf");
             cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("3-Qual a sua idade");
             idade = int.Parse(Console.ReadLine());
            Console.WriteLine("4-Qual o seu telefone");
             telefone = int.Parse(Console.ReadLine());
            Console.WriteLine("5-Qual a sua cidade");
             cidade = Console.ReadLine();
        }
        public void cadastroadministrador()
        {
            Console.WriteLine("1-Qual o seu nome");
             nome = Console.ReadLine();
            Console.WriteLine("2-Qual o seu cpf");
            cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("3-Qual a sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("4-Qual o seu telefone");
            telefone = int.Parse(Console.ReadLine());
            Console.WriteLine("5-Qual a sua cidade");
           cidade = Console.ReadLine();
            Console.WriteLine("6-qual o seu banco");
           banco=Console.ReadLine();
            Console.WriteLine("7-Qual o nome do estacionamento");
        }

    }
}
