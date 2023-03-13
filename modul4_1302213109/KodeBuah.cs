using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302213109
{
    internal class KodeBuah
    {
        private Dictionary<string, string> tabelKodeBuah = new Dictionary<string, string>
        {
            {"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"},
            {"Kurma", "K00"},
            {"Durian", "L00"},
            {"Anggur", "M00"},
            {"Melon", "N00"},
            {"Semangka", "O00"}
        };

        public string getKodeBuah(string buah)
        {
            if (tabelKodeBuah.ContainsKey(buah))
            {
                return tabelKodeBuah[buah];
            }
            else
            {
                return "Kode Buah tidak ditemukan.";
            }
        }
    }

    class Program_KB
    {
        static void Main_KB(string[] args)
        {
            KodeBuah kodebuah = new KodeBuah();

            Console.WriteLine(kodebuah.getKodeBuah("Apel")); // Output: A00
            Console.WriteLine(kodebuah.getKodeBuah("Aprikot")); // Output: B00
            Console.WriteLine(kodebuah.getKodeBuah("Alpukat")); // Output: C00
            Console.WriteLine(kodebuah.getKodeBuah("Pisang")); // Output: D00
            Console.WriteLine(kodebuah.getKodeBuah("Paprika")); // Output: E00
            Console.WriteLine(kodebuah.getKodeBuah("Blackberry")); // Output: F00
            Console.WriteLine(kodebuah.getKodeBuah("Ceri")); // Output: H00
            Console.WriteLine(kodebuah.getKodeBuah("Kelapa")); // Output: I00
            Console.WriteLine(kodebuah.getKodeBuah("Jagung")); // Output: J00
            Console.WriteLine(kodebuah.getKodeBuah("Kurma")); // Output: K00
            Console.WriteLine(kodebuah.getKodeBuah("Durian")); // Output: L00
            Console.WriteLine(kodebuah.getKodeBuah("Anggur")); // Output: M00
            Console.WriteLine(kodebuah.getKodeBuah("Melon")); // Output: N00
            Console.WriteLine(kodebuah.getKodeBuah("Semangka")); // Output: O00
            Console.WriteLine(kodebuah.getKodeBuah("Rambutan")); // Output: Kode Buah tidak ditemukan.
        }
    }
}
