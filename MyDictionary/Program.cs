using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Bilgisayar");
            myDictionary.Add(2, "Mouse");
            myDictionary.Add(3, "Klavye");
            myDictionary.Add(4, "LCD Ekran");
            myDictionary.Add(5, "Usb Flash");
        }
    }
}
