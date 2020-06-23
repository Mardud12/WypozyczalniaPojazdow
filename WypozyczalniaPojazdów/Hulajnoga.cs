namespace WypozyczalniaPojazdów
{
    public class Hulajnoga : Pojazd
    {
        private int Dystans { set; get; }
        private RodzajHulajnogi RodzajHulajnogi { set; get; }


        public Hulajnoga(string marka, string model, RodzajPojazdu rodzajPojazdu,
            RodzajHulajnogi rodzajHulajnogi, int dystans) : base(marka, model, rodzajPojazdu)
        {
            RodzajHulajnogi = rodzajHulajnogi;
            Dystans = dystans;
        }

        public override string WypiszInfo()
        {
            return ("{0} {1} {2} {3} {4}", Id, Marka, Model, RodzajHulajnogi, Dystans).ToString();

        }
    }
}
