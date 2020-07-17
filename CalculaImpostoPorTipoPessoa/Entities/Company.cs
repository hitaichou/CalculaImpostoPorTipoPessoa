namespace CalculaImpostoPorTipoPessoa.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        private double _vlTax;

        /*public Company()
        {
        }*/

        public Company(string name, double anualincome, int numberOfEmployees) :base(name, anualincome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                _vlTax = AnualIncome * 0.14;
            }
            else
            {
                _vlTax = AnualIncome * 0.16;
            }

            return _vlTax;
        }
    }
}
