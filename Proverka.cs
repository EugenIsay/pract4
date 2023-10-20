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
        private string read = "";
        private bool dot;
        private float arg0 = 0;
        private float arg1 = 0;
        private float arg2 = 0;
        private bool result;
        private void one_num(string read)
        {
            result = float.TryParse(read, out arg0);
            if (arg0 < 1) result = false;
        }
        private void two_num(string read1, string read2)
        {
            result = float.TryParse(read1, out arg0);
            if (result == true) result = float.TryParse(read2, out arg1);
            if (arg0 < 1 || arg1 < 1) result = false;
        }
        private void three_num(string read1, string read2, string read3)
        {
            result = float.TryParse(read1, out arg0);
            if (result == true) result = float.TryParse(read2, out arg1);
            if (result == true) result = float.TryParse(read3, out arg2);
            if (arg0 < 1 || arg1 < 1 || arg2 < 1) result = false;
        }
        public bool show_result()
        {
            return result;
        }
        public void show_one(out float arg0)
        {
            read_key();
            arg0 = this.arg0;
        }
        public void show_two(out float arg0, out float arg1)
        {
            two_num(Console.ReadLine(), Console.ReadLine());
            arg0 = this.arg0;
            arg1 = this.arg1;
        }
        public void show_three(out float arg0, out float arg1, out float arg2)
        {
            three_num(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            arg0 = this.arg0;
            arg1 = this.arg1;
            arg2 = this.arg2;
        }
        private void read_key()
        {
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
                        Console.Write(" ");
                        goto end;
                    case "Backspace":
                        if (read.Substring(read.Length - 1) == ",")
                            dot = false;
                        read.Remove(0, 1);
                        //Console.SetCursorPosition(Cursor.Position.X - 60, Cursor.Position.X);
                        break;
                    default:
                        break;
                }
            }
        end:;
            Console.WriteLine(read);
        }
    }
}
