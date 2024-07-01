using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class veiculo
    {
        List<veiculo> Carro = new List<veiculo>();
        List<veiculo> Moto = new List<veiculo>();
        public int Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Fabricadora { get; set; }

        public void VerificarVeiculoDoUsuario()
        {
            //
            Carro.Clear();
            Moto.Clear();
            if (Marca == null )
            {

            }
        } 


    }
}
