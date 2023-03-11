namespace LAB1.Shared
{
    public class Panstwo
    {
        public int ID { get; set; }
        public string NazwaPowszechna { get; set; }
        public string NazwaOficjalna { get; set; }
        public string KodISO3166 { get; set; }
        public TypRzadu? TypRzadu { get; set; }
        public int TypRzaduID { get; set; }
        public int LiczbaObywateli { get; set; }
        public double HDI { get; set; }
        public string URLflagi { get; set; }
    }
}