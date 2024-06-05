using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
            
        }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(Suite.CapacidadeSuite >= hospedes.Count)
            {
                Hospedes = hospedes;
            } else
            {
                Console.WriteLine("A quantidade de hóspedes excede a capacidade da suíte");
            }        
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int QuantidadeHospedes()
        {
            if (Hospedes != null)
            {
                return Hospedes.Count();
            } else
            {
                return 0; 
            }
        }

        public decimal RetornaValorDiaria ()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
                valor *= 0.9m;
            }

            return valor;
            
        }

    
    }
}