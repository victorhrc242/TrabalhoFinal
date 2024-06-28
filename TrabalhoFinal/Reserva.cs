using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class Reserva
    {
        List<Reserva> reservar = new List<Reserva>();
        List<Reserva> VagasDispo = new List<Reserva>();
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public bool DataEntrada { get; set; }
        public bool DataSaida { get; set; }

        public string Veiculo { get; set; }

        public void ReservarVaga()
        {
            Console.WriteLine("Qual seu nome ?");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual seu veiculo?");
            Veiculo = Console.ReadLine();
            Console.WriteLine("Quando vai ser sua data de Entrada?");
            DataEntrada = bool.Parse(Console.ReadLine());
            Console.WriteLine("Quando vai ser sua data de Saida?");
            DataSaida= bool.Parse(Console.ReadLine());
        }
        public void VagasDisponiveis()
        {
            //mostra todas as vagas disponiveis
        }
    }
}
