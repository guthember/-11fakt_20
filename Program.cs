using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace macskak
{
  struct Macska
  {
    public string nev;
    public string fajta;
    public bool nem;
    public int tomeg;
    public int kor;
  }

  class Program
  {
    static void Main(string[] args)
    {
      #region Előzmény
      // int string="szó" char='k' bool double float 
      // int[] tomb  = new int[10] string[] double[]

      // név, fajtája, neme (fiú) , tömege, kor
      // Cirmi, házimacska, nem, 3 kg, 4 év
      // Foltos, sziámi, igen, 5 kg, 8 év

      // string[] nev
      // string[] fajta
      // bool[] neme
      // int[] tomeg
      // int[] kor 
      #endregion

      //Macska cirmi = new Macska();

      Macska[] macskak = new Macska[3];
      
      // adatok beolvasása
      StreamReader file = new StreamReader("nyilvantart.txt");

      for (int i = 0; i < 3; i++)
      {
        string sor = file.ReadLine();
        // sor = "macskak házimacska false 3 4"
        string[] adatok = sor.Split(' ');
        // adatok[0] = "macskak", adatok[1] = "házimacska"
        // adatok[2] = "false", adatok[3] = "3"
        // adatok[4] = "4"

        macskak[i].nev = adatok[0];
        macskak[i].fajta = adatok[1];
        macskak[i].tomeg = Convert.ToInt32(adatok[3]);
        macskak[i].kor = Convert.ToInt32(adatok[4]);
        macskak[i].nem = Convert.ToBoolean(adatok[2]);

        Console.WriteLine("A macska neve: {0}", macskak[i].nev);
        Console.WriteLine("fajtája: {0}", macskak[i].fajta);
        if (macskak[i].nem)
        {
          Console.WriteLine("nem: bak");
        }
        else
        {
          Console.WriteLine("nem: nőstény");
        }
        Console.WriteLine("kora: {0}", macskak[i].kor);
        Console.WriteLine("tömege: {0}", macskak[i].tomeg);
        Console.WriteLine("------------------------------");
      }

      file.Close();

      Console.ReadKey();
    }
  }
}
