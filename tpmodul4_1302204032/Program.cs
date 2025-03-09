namespace tpmodul4_1302204032
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display kelurahan list with postal codes
            Console.WriteLine("Daftar Kelurahan");
            Console.WriteLine("===================================");
            Console.WriteLine("Kelurahan \t |    Kode Pos");
            Console.WriteLine("===================================");

            // Display table using the new method
            Console.WriteLine($"{"Batununggal",-16} |     {KodePos.getKodePos("Batununggal")}");
            Console.WriteLine($"{"Kujangsari",-16} |     {KodePos.getKodePos("Kujangsari")}");
            Console.WriteLine($"{"Mengger",-16} |     {KodePos.getKodePos("Mengger")}");
            Console.WriteLine($"{"Wates",-16} |     {KodePos.getKodePos("Wates")}");
            Console.WriteLine($"{"Cijaura",-16} |     {KodePos.getKodePos("Cijaura")}");
            Console.WriteLine($"{"Jatisari",-16} |     {KodePos.getKodePos("Jatisari")}");
            Console.WriteLine($"{"MargaSari",-16} |     {KodePos.getKodePos("MargaSari")}");
            Console.WriteLine($"{"Sekejati",-16} |     {KodePos.getKodePos("Sekejati")}");
            Console.WriteLine($"{"Kebonwaru",-16} |     {KodePos.getKodePos("Kebonwaru")}");
            Console.WriteLine($"{"Maleer",-16} |     {KodePos.getKodePos("Maleer")}");
            Console.WriteLine($"{"Samoja",-16} |     {KodePos.getKodePos("Samoja")}");

            Console.WriteLine("\n===================================");
        }
    }
}