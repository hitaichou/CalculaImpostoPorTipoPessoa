using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaImpostoPorTipoPessoa.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualincome, double healthExpenditures):base(name, anualincome)
        {
            HealthExpenditures = HealthExpenditures;
        }

    }
}
