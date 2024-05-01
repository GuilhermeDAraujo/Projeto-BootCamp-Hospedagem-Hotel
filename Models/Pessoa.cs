using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Pessoa
    {
        public string Nome {get;set;}
        public string SobreNome {get;set;}
        public string NomeCompleto => $"{Nome} {SobreNome.ToUpper()}";

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }
    }
}