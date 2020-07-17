namespace CalculaImpostoPorTipoPessoa.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        
        public TaxPayer(string name, double anualincome)
        {
            Name = name;
            AnualIncome = anualincome;
        }
        //Implemento método abstrato
        public abstract double Tax();      
    }
}
