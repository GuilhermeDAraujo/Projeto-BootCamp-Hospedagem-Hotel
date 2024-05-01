using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Reserva
    {
        public List <Pessoa> Hospedes {get; set;}
        public Suite Suite {get;set;}
        public int DiasReservados {get;set;}

        public Reserva()
        {
            
        }

        public Reserva (int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quanitidade de hospedes não pode ser maior que a capacidade da suite.");
            } 
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int contador = Hospedes.Count();
            return contador;
        }

        public decimal CalcularValorDiaria()
        {
            return Suite.ValorDiaria * DiasReservados * (DiasReservados >= 10 ? 0.9M : 1);
        }

    }
}