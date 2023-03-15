// See https://aka.ms/new-console-template for more information
namespace JURNAL4_1302213003
{
    class Mainprogram
    {
        public static void Main(string[] args)
        {
            kodeBuah a = new kodeBuah();
            Console.WriteLine("Blackberry");
            a.getkodebuah("Blackberry");
            Console.WriteLine("\n");

            Console.WriteLine("Berikut kode beserta buahnya");
            a.getallkodebuah();
            Console.WriteLine("\n");

        }
    }
    class kodeBuah
    {
        Dictionary<String, string> buah = new Dictionary<String, string>(){
            {"Apel = ", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "G00"},
            {"Kelapa", "H00"},
            {"Jagung", "I00"},

        };

        public void getkodebuah(string kode)
        {
            if (buah.ContainsKey(kode))
            {
                Console.WriteLine(kode + " : " + buah[kode]);
            }
            else
            {
                Console.WriteLine(kode + "Kode tidak terdaftar");
            }
        }

        public void getallkodebuah()
        {
            foreach (KeyValuePair<string, string> i in buah)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
    }
}
