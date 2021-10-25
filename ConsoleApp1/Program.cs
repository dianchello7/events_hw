using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        private static int curLeft;
        private static int curTop;
        private static bool[,] isUsedPixels;
        private static int shapesToPrint;

        static void Main(string[] args)
        {
            SetConsole(80, 25);


        }

        static void SetConsole(int width, int height)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            curLeft = new Random().Next(width);
            curTop = new Random().Next(height);
            Console.SetCursorPosition(curLeft, curTop);
            isUsedPixels = new bool[width, height];
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write('*');
            isUsedPixels[width - 1, height - 1] = true;
        }

        static void Move(int newLeft, int newTop)
        {
            if (newLeft < Console.WindowWidth && newLeft > 0 && newTop < Console.WindowHeight && newTop > 0)
            {
                if (isUsedPixels[newLeft - 1, newTop - 1])
                {
                    //Console.WriteLine("Error");
                }
                else
                {
                    Console.SetCursorPosition(curLeft, curTop);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //Console.Write(' ');
                    Console.Write('*');

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(newLeft, newTop);
                    Console.Write('*');
                    isUsedPixels[newLeft - 1, newTop - 1] = true;
                    curLeft = newLeft;
                    curTop = newTop;
                }
            }
        }



    }
}


