using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaImpostoPorTipoPessoa.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualincome, int numberOfEmployees) :base(name, anualincome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
    }
}
