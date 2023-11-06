using System;
using System.Threading;
namespace TIC_TAC_TOE
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int valasztas;
        static int jelzo = 0;
        static string player1;
        static string player2;
        static void Main(string[] args)
        {
            Console.Write("1.Játékos neve:");
            player1 = Console.ReadLine();
            Console.Write("2.Játékos neve:");
            player2 = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine(player1+":X és "+player2+":O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {Console.WriteLine(player2+" következik");}
                else
                {Console.WriteLine(player1+" következik");}
                Console.WriteLine("\n");
                tabla();
                valasztas = int.Parse(Console.ReadLine());
                if (arr[valasztas] != 'X' && arr[valasztas] != 'O')
                {   if (player % 2 == 0)
                    {arr[valasztas] = 'O'; player++;}
                    else
                    {arr[valasztas] = 'X'; player++;}}
                else
                {   Console.WriteLine("Foglalt!", valasztas, arr[valasztas]);
                    Console.WriteLine("\n");
                    Thread.Sleep(1000);}
                jelzo = nyert();
            }
            while (jelzo != 1 && jelzo != -1);
            Console.Clear();
            tabla();
            if (jelzo == 1)
            {   if (player % 2 == 0)
                {Console.WriteLine(player1 + " Nyert!");}
                else
                { Console.WriteLine(player2 + " nyert!");}}
            else
            {Console.WriteLine("Döntetlen");}
            Console.ReadLine();
        }
        private static void tabla()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int nyert()
        {
            #region vizszintes nyeresi lehetosegek
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {return 1;}
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {return 1;}
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {return 1;}
            #endregion
            #region fuggoleges nyeresi lehetosegek
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {return 1;}
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {return 1;}
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {return 1;}
            #endregion
            #region atlos nyeresi lehetosegek
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {return 1;}
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {return 1;}
            #endregion
            #region dontetlen ellenorzes
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {return -1;}
            #endregion
            else
            {return 0;}
        }
    }
}
