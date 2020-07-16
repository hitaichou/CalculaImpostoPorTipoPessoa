using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CalculaImpostoPorTipoPessoa.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {

        }
        public TaxPayer(string name, double anualincome)
        {
            Name = name;
            AnualIncome = anualincome;
        }
    }
}
