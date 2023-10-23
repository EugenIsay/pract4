using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Figures
{
    internal class Proverka
    {
        ConsoleKeyInfo key;
        private string read;
        private bool dot;
        public void read_show(out float arg0)
        {
            arg0 = read_key();
            Console.WriteLine(" ");
        }
        public void read_show(out float arg0, out float arg1)
        {
            arg0 = read_key();
            arg1 = read_key();
            Console.WriteLine(" ");
        }
        public void read_show(out float arg0, out float arg1, out float arg2)
        {
            arg0 = read_key();
            arg1 = read_key();
            arg2 = read_key();
            Console.WriteLine(" ");
        }
        private float read_key()
        {
            read = "";
            dot = false;
            while (true)
            {
                key = Console.ReadKey(true);
                switch (key.Key.ToString())
                {
                    case "D1":
                    case "D2":
                    case "D3":
                    case "D4":
                    case "D5":
                    case "D6":
                    case "D7":
                    case "D8":
                    case "D9":
                    case "D0":
                        read += key.Key.ToString().Remove(0,1);
                        Console.Write(key.Key.ToString().Remove(0, 1));
                        break;
                    case "OemComma":
                        if (dot == false)
                        {
                            read += ",";
                            dot = true;
                            Console.Write(",");
                        }
                        break;
                    case "Enter":
                    case "Spacebar":
                        if (float.Parse(read) > 0)
                        {
                            Console.Write(" ");
                            goto end;
                        }
                        break;
                    case "Backspace":
                        if (read.Length > 0)
                        {
                            if (read.Substring(read.Length - 1) == ",")
                                dot = false;
                            read.Remove(0, 1);
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        }
                        break;
                    default:
                        break;
                }
            }
        end:;
            return float.Parse(read);
        }
    }
}
