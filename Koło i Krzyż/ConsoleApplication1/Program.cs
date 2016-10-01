using System;

namespace KółkoIKrzyż
{
    class MainClass
    {
        static char[] grids = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        static int wyb;
        static bool win = false;

        public static void Main()
        {
            while (!win)
            {
                Board();
                Move('X');
                win = Check('X');
                if (win)
                {
                    Console.WriteLine("Wygrał X GGGG");
                    break;
                }
                Board();
                Move('Y');
                win = Check('Y');
                if (win)
                {
                    Console.WriteLine("Wygrał X GGGG");
                    break;
                }
            }
            Console.ReadKey();
        }

        static void Board()
        {
            Console.WriteLine("wybierz pole od 1 - 9");
            Console.WriteLine(grids[0] + "|" + grids[1] + "|" + grids[2]);
            Console.WriteLine(grids[3] + "|" + grids[4] + "|" + grids[5]);
            Console.WriteLine(grids[6] + "|" + grids[7] + "|" + grids[8]);
        }

        static void Move(char gracz)
        {
            wyb = Convert.ToInt32(Console.ReadLine());

            int dupa = (int)wyb - 1;

            if (grids[dupa] == ' ')
            {
                grids[dupa] = gracz;
            }
            else
                Move(gracz);
        }

        static bool Check(char gracz)
        {
            if (grids[0] == gracz && grids[1] == gracz && grids[2] == gracz)
                return true;
            else if (grids[3] == gracz && grids[4] == gracz && grids[5] == gracz)
                return true;
            else if (grids[6] == gracz && grids[7] == gracz && grids[8] == gracz)
                return true;
            else if (grids[0] == gracz && grids[3] == gracz && grids[6] == gracz)
                return true;
            else if (grids[1] == gracz && grids[4] == gracz && grids[7] == gracz)
                return true;
            else if (grids[2] == gracz && grids[5] == gracz && grids[8] == gracz)
                return true;
            else if (grids[0] == gracz && grids[4] == gracz && grids[8] == gracz)
                return true;
            else if (grids[2] == gracz && grids[4] == gracz && grids[6] == gracz)
                return true;
            else
                return false;
        }
    }
}