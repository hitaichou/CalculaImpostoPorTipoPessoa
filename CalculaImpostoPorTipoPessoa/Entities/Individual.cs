namespace CalculaImpostoPorTipoPessoa.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        private double _vlAnnualIncome;

        /*public Individual()
        {
        }*/

        public Individual(string name, double anualincome, double healthExpenditures):base(name, anualincome)
        {
            HealthExpenditures = healthExpenditures;
        }
        //Regra para desconto de imposto
        public override double Tax()
        {
            if (AnualIncome < 20000)
            {                
                if(HealthExpenditures == 0.0)
                {
                    _vlAnnualIncome = AnualIncome * 0.15; //desconto 15% se não houve gasto com saúde
                }
                else
                {
                    _vlAnnualIncome = (AnualIncome * 0.15) - (HealthExpenditures * 0.5); //desconto 15% mas abato com 50% dos gastos com saúde
                }                
            }
            else
            {
                if (HealthExpenditures == 0.0)
                {
                    _vlAnnualIncome = AnualIncome * 0.25; //desconto 25% se não houve gasto com saúde
                }
                else
                {
                    _vlAnnualIncome = (AnualIncome * 0.25) - (HealthExpenditures * 0.5); //desconto 25% mas abato com 50% dos gastos com saúde
                }
            }
            return _vlAnnualIncome;
        }

    }
}
