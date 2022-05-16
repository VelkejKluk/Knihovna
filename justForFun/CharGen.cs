namespace justForFun
{
    internal class CharGen
    {
        private Random rndGen = new Random();

        private string _znakyAJ = "abcdefghijklmnopqrstuvwxyz";
        private string _cisla = "0123456789";
        private string _special = "#?_!*-+&%@";

        public char GenerujChar(bool znakyAJ, bool cisla, bool specialni)
        {
            string pole = VygenerujPole(znakyAJ, cisla, specialni);
            int index = _rndGen.Next(0, pole.Length);
            return pole[index];
        }
        public string GenerujZnaky(bool znakyAJ, bool cislice, bool specialni, int delka)
        {
            string vygenerovaneZnaky = "";

            for(int i = 0; i < delka; i++)
            {
                vygenerovaneZnaky += GenerujChar(znakyAJ, cislice, specialni);
            }
            return vygenerovaneZnaky;
        }
        private string VygenerujPole(bool znakyAJ, bool cisla, bool specialni)
        {
            Random rnd = new Random();
            string pole = "";
            
            if(znakyAJ == true )
            {
                pole += _znakyAJ;
            }
            else if (cisla == true)
            {
                pole += _cisla;
            }
            else if (specialni == true)
            {
                pole += _special;
            }
            return pole;
        }
    }
}
