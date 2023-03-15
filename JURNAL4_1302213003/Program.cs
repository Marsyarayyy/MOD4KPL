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

            Console.WriteLine("POSISI AWAL PLAYER :");

            posisikaraktergame posisi = new posisikaraktergame();

            posisi.key();


        }
    }
    class kodeBuah
    {
        Dictionary<String, string> buah = new Dictionary<String, string>(){
            {"Apel", "A00"},
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

    class posisikaraktergame
    {
        enum state { Tengkurap, Jongkok, Berdiri, Terbang };

        public void key()
        {
            state posisi = state.Berdiri;
            

            string[] status_posisi = { "Tengkurap", "Jongkok", "Berdiri", "Terbang" };
            do
            {
                Console.WriteLine("Posisi " + status_posisi[(int)posisi]);
                Console.WriteLine("Command : ");
                String command = Console.ReadLine();
                switch (posisi)
                {
                    case state.Berdiri:
                        if (command == "s")
                        {
                            posisi = state.Jongkok;

                        }
                        else if (command == "w")
                        {
                            posisi = state.Terbang;

                        }
                        break;
                    case state.Jongkok:
                        if (command == "s")
                        {
                            posisi = state.Tengkurap;
                            Console.WriteLine("Posisi Istirahat");

                        }
                        else if (command == "w")
                        {
                            posisi = state.Berdiri;
                            Console.WriteLine("Posisi Standby");
                        }
                        break;
                    case state.Tengkurap:
                        if (command == "w")
                        {
                            posisi = state.Jongkok;

                        }
                        break;

                    }
                } while (true);
            }

        }
    }

