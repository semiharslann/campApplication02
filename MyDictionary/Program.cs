using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> oyunlar = new MyDictionary<int, string>();
            oyunlar.Add(130, "Counter-Strike: Global Offensive");
            oyunlar.Add(160, "Grand Theft Auto V");
            oyunlar.Add(250, "Cyberpunk 2077");
        }
    }
}
