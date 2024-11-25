using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        class karakter
        {
            public int?[] specs = new int?[16] {null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null};
            public int id;

            public karakter(char c)
            {
                this.id = (int)c;
                switch (c)
                {
                    case '0':
                        this.specs[0] = 1;
                        this.specs[1] = 12;
                        this.specs[2] = 11;
                        this.specs[3] = 2;
                        this.specs[4] = 7;
                        this.specs[5] = 8;
                        break;
                    case '1':
                        this.specs[0] = 131;
                        this.specs[1] = 12;
                        this.specs[2] = 11;
                        this.specs[3] = 6;
                        this.specs[4] = 7;
                        break;
                    case '2':
                        this.specs[0] = 2;
                        this.specs[1] = 7;
                        this.specs[2] = 8;
                        this.specs[3] = 12;
                        this.specs[4] = 9;
                        break;
                    case '3':
                        this.specs[0] = 9;
                        this.specs[1] = 2;
                        this.specs[2] = 7;
                        this.specs[3] = 12;
                        this.specs[4] = 11;
                        break;
                    case '4':
                        this.specs[0] = 11;
                        this.specs[1] = 9;
                        this.specs[2] = 12;
                        this.specs[3] = 1;
                        break;
                    case '5':
                        this.specs[0] = 1;
                        this.specs[1] = 2;
                        this.specs[2] = 7;
                        this.specs[3] = 9;
                        this.specs[4] = 11;
                        break;
                    case '6':
                        this.specs[0] = 1;
                        this.specs[1] = 2;
                        this.specs[2] = 7;
                        this.specs[3] = 9;
                        this.specs[4] = 11;
                        this.specs[5] = 8;
                        break;
                    case '7':
                        this.specs[0] = 9;
                        this.specs[1] = 2;
                        this.specs[2] = 11;
                        this.specs[3] = 12;
                        break;
                    case '8':
                        this.specs[0] = 9;
                        this.specs[1] = 2;
                        this.specs[2] = 7;
                        this.specs[3] = 12;
                        this.specs[4] = 11;
                        this.specs[5] = 1;
                        this.specs[6] = 8;
                        break;
                    case '9':
                        this.specs[0] = 9;
                        this.specs[1] = 2;
                        this.specs[2] = 7;
                        this.specs[3] = 12;
                        this.specs[4] = 11;
                        this.specs[5] = 1;
                        break;
                    case 'a':
                        this.specs[0] = 9;
                        this.specs[1] = 2;
                        this.specs[2] = 1;
                        this.specs[3] = 12;
                        this.specs[4] = 11;
                        this.specs[5] = 8;
                        break;
                    case 'b':
                        this.specs[0] = 1;
                        this.specs[1] = 8;
                        this.specs[2] = 7;
                        this.specs[3] = 9;
                        this.specs[4] = 11;
                        break;
                    case 'c':
                        this.specs[0] = 7;
                        this.specs[1] = 8;
                        this.specs[2] = 9;
                        break;
                    case 'd':
                        this.specs[0] = 12;
                        this.specs[1] = 8;
                        this.specs[2] = 7;
                        this.specs[3] = 9;
                        this.specs[4] = 11;
                        break;
                    case 'e':
                        this.specs[0] = 1;
                        this.specs[1] = 8;
                        this.specs[2] = 7;
                        this.specs[3] = 9;
                        this.specs[4] = 2;
                        break;
                    case 'f':
                        this.specs[0] = 1;
                        this.specs[1] = 8;
                        this.specs[3] = 9;
                        this.specs[4] = 2;
                        break;
                    case 'g':
                        this.specs[0] = 1;
                        this.specs[1] = 8;
                        this.specs[2] = 7;
                        this.specs[3] = 10;
                        this.specs[4] = 2;
                        this.specs[5] = 3;
                        this.specs[6] = 6;
                        this.specs[7] = 5;
                        break;
                    case 'h':
                        this.specs[0] = 1;
                        this.specs[1] = 8;
                        this.specs[2] = 11;
                        this.specs[3] = 9;
                        this.specs[4] = 12;
                        break;
                    case 'i':
                        this.specs[0] = 11;
                        this.specs[1] = 12;
                        break;
                    case 'j':
                        this.specs[0] = 11;
                        this.specs[1] = 12;
                        this.specs[2] = 7;
                        break;
                    case 'k':
                        this.specs[0] = 1;
                        this.specs[1] = 8;
                        this.specs[2] = 131;
                        this.specs[3] = 152;
                        break;
                    case 'l':
                        this.specs[0] = 11;
                        this.specs[1] = 12;
                        this.specs[2] = 6;
                        break;
                    case 'm':
                        this.specs[0] = 8;
                        this.specs[1] = 2;
                        this.specs[2] = 12;
                        this.specs[3] = 3;
                        this.specs[4] = 5;
                        this.specs[5] = 1;
                        this.specs[6] = 4;
                        break;
                    case 'n':
                        this.specs[0] = 8;
                        this.specs[1] = 9;
                        this.specs[2] = 11;
                        break;
                    case 'o':
                        this.specs[0] = 8;
                        this.specs[1] = 9;
                        this.specs[2] = 11;
                        this.specs[3] = 7;
                        break;
                    case 'p':
                        this.specs[0] = 8;
                        this.specs[1] = 9;
                        this.specs[2] = 1;
                        this.specs[3] = 2;
                        this.specs[4] = 12;
                        break;
                    case 'q':
                        this.specs[0] = 11;
                        this.specs[1] = 9;
                        this.specs[2] = 1;
                        this.specs[3] = 2;
                        this.specs[4] = 12;
                        break;
                    case 'r':
                        this.specs[0] = 8;
                        this.specs[1] = 1;
                        this.specs[2] = 2;
                        break;
                    case 's':
                        this.specs[0] = 5;
                        this.specs[1] = 9;
                        this.specs[2] = 1;
                        this.specs[3] = 2;
                        this.specs[4] = 7;
                        this.specs[5] = 3;
                        this.specs[6] = 10;
                        this.specs[7] = 6;
                        break;
                    case 't':
                        this.specs[0] = 11;
                        this.specs[1] = 12;
                        this.specs[2] = 3;
                        this.specs[3] = 2;
                        break;
                    case 'u':
                        this.specs[0] = 11;
                        this.specs[1] = 12;
                        this.specs[2] = 1;
                        this.specs[3] = 8;
                        this.specs[4] = 7;
                        break;
                    case 'v':
                        this.specs[0] = 152;
                        this.specs[1] = 161;
                        break;
                    case 'w':
                        this.specs[0] = 8;
                        this.specs[1] = 7;
                        this.specs[2] = 11;
                        this.specs[3] = 6;
                        this.specs[4] = 5;
                        this.specs[5] = 1;
                        this.specs[6] = 4;
                        break;
                    case 'x':
                        this.specs[0] = 141;
                        this.specs[1] = 132;
                        this.specs[2] = 151;
                        this.specs[3] = 162;
                        break;
                    case 'y':
                        this.specs[0] = 11;
                        this.specs[1] = 132;
                        this.specs[2] = 141;
                        break;
                    case 'z':
                        this.specs[0] = 2;
                        this.specs[1] = 3;
                        this.specs[2] = 141;
                        this.specs[3] = 151;
                        this.specs[4] = 7;
                        this.specs[5] = 6;
                        break;
                    default:
                        break;
                }
            }
        }

        static karakter[] karakterler = new karakter[36];

        static void setup()
        {
            karakterler[0] = new karakter('0');
            karakterler[1] = new karakter('1');
            karakterler[2] = new karakter('2');
            karakterler[3] = new karakter('3');
            karakterler[4] = new karakter('4');
            karakterler[5] = new karakter('5');
            karakterler[6] = new karakter('6');
            karakterler[7] = new karakter('7');
            karakterler[8] = new karakter('8');
            karakterler[9] = new karakter('9');
            karakterler[10]  = new karakter('a');
            karakterler[11]  = new karakter('b');
            karakterler[12]  = new karakter('c');
            karakterler[13]  = new karakter('d');
            karakterler[14]  = new karakter('e');
            karakterler[15]  = new karakter('f');
            karakterler[16]  = new karakter('g');
            karakterler[17]  = new karakter('h');
            karakterler[18]  = new karakter('i');
            karakterler[19]   = new karakter('j');
            karakterler[20]   = new karakter('k');
            karakterler[21]  = new karakter('l');
            karakterler[22]  = new karakter('m');
            karakterler[23]  = new karakter('n');
            karakterler[24]  = new karakter('o');
            karakterler[25]  = new karakter('p');
            karakterler[26]  = new karakter('q');
            karakterler[27]  = new karakter('r');
            karakterler[28] = new karakter('s');
            karakterler[29]  = new karakter('t');
            karakterler[30]  = new karakter('u');
            karakterler[31]  = new karakter('v');
            karakterler[32]  = new karakter('w');
            karakterler[33]  = new karakter('x');
            karakterler[34]  = new karakter('y');
            karakterler[35]  = new karakter('z');

        }

        static int cc = 0;
        static void Main()
        {
            setup();

            Console.Write("input: ");
            string input = Console.ReadLine();
            char[] ca = input.ToCharArray();

            for (int i = 0; i < ca.Length; i++)
            {
                ca[i] = char.ToLower(ca[i]);
            }

            Console.Clear();

            for (int x = 0; x < ca.Length; x++)
            {
                for (int i = 0; i < karakterler.Length; i++)
                {
                    if ((int)ca[cc] == karakterler[i].id)
                    {
                        for (int j = 0; j < karakterler[i].specs.Length; j++)
                        {
                            switch (karakterler[i].specs[j])
                            {
                                case 1:
                                    Console.SetCursorPosition(cc * 6 + 0, 1);
                                    Console.Write("|");
                                    break;
                                case 2:
                                    Console.SetCursorPosition(cc * 6 + 1, 0);
                                    Console.Write("_");
                                    break;
                                case 3:
                                    if ((char)karakterler[i].id == 'g' || (char)karakterler[i].id == 's')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 2, 0);
                                        Console.Write("_");
                                        break;
                                    }
                                    else
                                    Console.SetCursorPosition(cc * 6 + 3, 0);
                                    Console.Write("_");
                                    break;
                                case 4:
                                    Console.SetCursorPosition(cc * 6 + 4, 1);
                                    Console.Write("|");
                                    break;
                                case 5:
                                    if ((char)karakterler[i].id == 'g' || (char)karakterler[i].id == 's')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 3, 2);
                                        Console.Write("|");
                                        break;
                                    }
                                    else
                                    Console.SetCursorPosition(cc * 6 + 4, 2);
                                    Console.Write("|");
                                    break;
                                case 6:
                                    if ((char)karakterler[i].id == 'z')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 5, 2);
                                        Console.Write("_");
                                        break;
                                    }

                                    else if ((char)karakterler[i].id == 'g' || (char)karakterler[i].id == 's')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 2, 2);
                                        Console.Write("_");
                                        break;
                                    }
                                    else
                                    Console.SetCursorPosition(cc * 6 + 3, 2);
                                    Console.Write("_");
                                    break;
                                case 7:
                                    if ((char)karakterler[i].id == 'z')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 3, 2);
                                        Console.Write("_");
                                        break;
                                    }
                                    else
                                        Console.SetCursorPosition(cc * 6 + 1, 2);
                                    Console.Write("_");
                                    break;
                                case 8:
                                    Console.SetCursorPosition(cc * 6 + 0, 2);
                                    Console.Write("|");
                                    break;
                                case 9:
                                    Console.SetCursorPosition(cc * 6 + 1, 1);
                                    Console.Write("_");
                                    break;
                                case 10:
                                    if ((char)karakterler[i].id == 'g' || (char)karakterler[i].id == 's')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 2, 1);
                                        Console.Write("_");
                                        break;
                                    }
                                    else
                                    Console.SetCursorPosition(cc * 6 + 3, 1);
                                    Console.Write("_");
                                    break;
                                case 11:
                                    Console.SetCursorPosition(cc * 6 + 2, 2);
                                    Console.Write("|");
                                    break;
                                case 12:
                                    Console.SetCursorPosition(cc * 6 + 2, 1);
                                    Console.Write("|");
                                    break;
                                case 131:
                                    Console.SetCursorPosition(cc * 6 + 1, 1);
                                    Console.Write("/");
                                    break;
                                case 132:
                                    Console.SetCursorPosition(cc * 6 + 1, 1);
                                    Console.Write("\\");
                                    break;
                                case 141:
                                    if ((char)karakterler[i].id == 'x')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 2, 1);
                                        Console.Write("/");
                                        break;
                                    }
                                    else
                                    Console.SetCursorPosition(cc * 6 + 3, 1);
                                    Console.Write("/");
                                    break;
                                case 142:
                                    Console.SetCursorPosition(cc * 6 + 3, 1);
                                    Console.Write("\\");
                                    break;
                                case 151:
                                    if ((char)karakterler[i].id == 'z')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 2, 2);
                                        Console.Write("/");
                                        break;
                                    }
                                    else 
                                        Console.SetCursorPosition(cc * 6 + 1, 2);
                                    Console.Write("/");
                                    break;
                                case 152:
                                    Console.SetCursorPosition(cc * 6 + 1, 2);
                                    Console.Write("\\");
                                    break;
                                case 161:
                                    if ((char)karakterler[i].id == 'v')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 2, 2);
                                        Console.Write("/");
                                        break;
                                    }
                                    else
                                    Console.SetCursorPosition(cc * 6 + 3, 2);
                                    Console.Write("/");
                                    break;
                                case 162:
                                    if ((char)karakterler[i].id == 'x')
                                    {
                                        Console.SetCursorPosition(cc * 6 + 2, 2);
                                        Console.Write("\\");
                                        break;
                                    }
                                    else
                                    Console.SetCursorPosition(cc * 6 + 3, 2);
                                    Console.Write("\\");
                                    break;
                            }
                        }
                    }
                }
                cc++;
            }

            Console.ReadLine();
   
        }
    }
}
