using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringa = "prova \" metto anche le virgolette\" ";
            Console.WriteLine(stringa);
            //\n vado a capo come in HTML
            
            //CONCATENAZIONE
            string nome = "Angelo";
            string cognome = "Dalo";
            string stringa2 = "ciao sono " + nome  + " " + cognome;
            //FORMATTAZIONE
            Console.WriteLine("ciao sono {0} {1}", nome, cognome);
            string stringa3 = string.Format("ciao sono {0} {1}", nome, cognome);
            //INTERPOLLAZIONE
            Console.WriteLine($"buongiorno sono {nome} {cognome}");

            //METODI
            string stringa4 = nome.ToUpper();
            string stringa5 = nome.ToLower();
            int stringa6 = nome.Length;
            int stringa7 = nome.IndexOf("A");
            Console.WriteLine(stringa6);
            Console.WriteLine(stringa7);
        }
    }
}