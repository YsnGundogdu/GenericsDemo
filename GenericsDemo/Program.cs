using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(394, "Yasin Gündoğdu");
            myDictionary.Add(1782, "Yusuf Yetişkin");
            myDictionary.Add(2284, "Oğuzhan Yıldız");
            myDictionary.Add(1589, "İlker korkmaz");

            myDictionary.List();
        }
    }
}
