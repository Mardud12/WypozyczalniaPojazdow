namespace WypozyczalniaPojazdów
{
    public class Rower : Pojazd
    {
        private int IlośćPrzeżutek { set; get; }
        private RodzajRoweru RodzajRoweru { set; get; }


        public Rower(string marka, string model, RodzajPojazdu rodzajPojazdu,
            RodzajRoweru rodzajRoweru, int ilośćPrzeżutek) : base(marka, model, rodzajPojazdu)
        {
            RodzajRoweru = rodzajRoweru;
            IlośćPrzeżutek = ilośćPrzeżutek;
        }

        public override string WypiszInfo()
        {
            return ("{0} {1} {2} {3} {4} {5}", Id, Marka, Model, RodzajRoweru, IlośćPrzeżutek).ToString();

        }
    }
}
