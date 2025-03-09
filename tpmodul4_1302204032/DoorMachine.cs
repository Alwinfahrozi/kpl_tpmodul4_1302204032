using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204032
{
    public enum pintu { terkunci, terbuka };
    public enum kegiatan { bukaPintu, kunciPintu };

    class DoorMachine
    {
        private pintu state;

        // Constructor - state awal adalah terkunci
        public DoorMachine()
        {
            state = pintu.terkunci;
        }

        // Method untuk mengubah state pintu berdasarkan input
        public void ubahStatePintu(kegiatan opsi)
        {
            switch (state)
            {
                case pintu.terkunci:
                    if (opsi == kegiatan.bukaPintu)
                    {
                        Console.WriteLine("Pintu tidak terkunci");
                        state = pintu.terbuka;
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terkunci");
                    }
                    break;
                case pintu.terbuka:
                    if (opsi == kegiatan.kunciPintu)
                    {
                        Console.WriteLine("Pintu terkunci");
                        state = pintu.terkunci;
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terbuka");
                    }
                    break;
            }
        }

        // Method untuk mendapatkan status pintu saat ini
        public void getStatusPintu()
        {
            Console.WriteLine("Status Pintu: " + state);
        }
    }
}