using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204032
{
    class KodePos
    {
        public enum kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, MargaSari, Sekejati, Kebonwaru, Maleer, Samoja };

        // Table-driven technique implementation
        private static Dictionary<kelurahan, string> tabelKodePos = new Dictionary<kelurahan, string>()
        {
            { kelurahan.Batununggal, "40266" },
            { kelurahan.Kujangsari, "40287" },
            { kelurahan.Mengger, "40267" },
            { kelurahan.Wates, "40256" },
            { kelurahan.Cijaura, "40287" },
            { kelurahan.Jatisari, "40286" },
            { kelurahan.MargaSari, "40286" },
            { kelurahan.Sekejati, "40286" },
            { kelurahan.Kebonwaru, "40272" },
            { kelurahan.Maleer, "40274" },
            { kelurahan.Samoja, "40273" }
        };

        // Method to get postal code using table-driven approach
        public static int getkodePos(kelurahan Kelurahan)
        {
            return int.Parse(tabelKodePos[Kelurahan]);
        }

        // New method that returns postal code from given label
        public static string getKodePos(string kelurahanLabel)
        {
            // Convert the label to enum and return the corresponding postal code
            if (Enum.TryParse(kelurahanLabel, out kelurahan kel))
            {
                return tabelKodePos[kel];
            }
            return "Kode pos tidak ditemukan";
        }
    }
}