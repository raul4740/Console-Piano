internal class Program
{
    // Fields
    public static string America = "America the Beautiful -- Katharine Lee Bates (1895)";
    public static int cont = 0;
    public static int contFondo = 0;
    public static int contJ = 0;
    public static int contJ1 = 0;
    public static int contmenu = 0;
    public static string Cucaracha = "La Cucaracha -- Francisco Rodr\x00edguez Mar\x00edn (1818)";
    public static string Freeplay = "Freeplay";
    public static string FurElise = "F\x00fcr Elise -- Ludwig van Beethoven (1810)";
    public static int global_x = 0x2c;
    public static int global_y = 13;
    public static string Habanera = "Habanera -- Georges Bizet (1845)";
    public static ConsoleKeyInfo k;
    public static string Marcha = "Marcha Nupcial - Felix Mendelssohn (1842)";
    public static string T1 = "|: |                                         _______________________________________________________                                            | :|";
    public static string T2 = "|: |                                        |  |█| |█|  |  |█| |█| |█|  |  |█| |█|  |  |█| |█| |█|  |                                           | :|";
    public static string T3 = "|: |                                        |  |█| |█|  |  |█| |█| |█|  |  |█| |█|  |  |█| |█| |█|  |                                           | :|";
    public static string T4 = "|: |                                        |  |█| |█|  |  |█| |█| |█|  |  |█| |█|  |  |█| |█| |█|  |                                           | :|";
    public static string T5 = "|: |                                        |  |█| |█|  |  |█| |█| |█|  |  |█| |█|  |  |█| |█| |█|  |                                           | :|";
    public static string T6 = "|: |                                        |   |   |   |   |   |   |   |   |   |   |   |   |   |   |                                           | :|";
    public static string T7 = "|: |                                        |   |   |   |   |   |   |   |   |   |   |   |   |   |   |                                           | :|";
    public static string T8 = "|: |                                        |___|___|___|___|___|___|___|___|___|___|___|___|___|___|                                           | :|";
    public static Thread thread1 = new Thread(new ThreadStart(Program.Fondo));

    // Methods
    public static void AmericaPlay()
    {
        if (contJ == 0)
        {
            F6();
        }
        if (contJ == 1)
        {
            F6();
        }
        if (contJ == 2)
        {
            FourKey();
        }
        if (contJ == 3)
        {
            FourKey();
        }
        if (contJ == 4)
        {
            F6();
        }
        if (contJ == 5)
        {
            F6();
        }
        if (contJ == 6)
        {
            ThreeKey();
        }
        if (contJ == 7)
        {
            ThreeKey();
        }
        if (contJ == 8)
        {
            FourKey();
        }
        if (contJ == 9)
        {
            F5();
        }
        if (contJ == 10)
        {
            F6();
        }
        if (contJ == 11)
        {
            SevenKey();
        }
        if (contJ == 12)
        {
            EightKey();
        }
        if (contJ == 13)
        {
            F6();
        }
        if (contJ == 14)
        {
            F6();
        }
        if (contJ == 15)
        {
            F6();
        }
        if (contJ == 0x10)
        {
            FourKey();
        }
        if (contJ == 0x11)
        {
            FourKey();
        }
        if (contJ == 0x12)
        {
            F6();
        }
        if (contJ == 0x13)
        {
            F6();
        }
        if (contJ == 20)
        {
            ThreeKey();
        }
        if (contJ == 0x15)
        {
            ThreeKey();
        }
        if (contJ == 0x16)
        {
            ZeroKey();
        }
        if (contJ == 0x17)
        {
            NineKey();
        }
        if (contJ == 0x18)
        {
            ZeroKey();
        }
        if (contJ == 0x19)
        {
            QstnKey();
        }
        if (contJ == 0x1a)
        {
            SevenKey();
        }
        if (contJ == 0x1b)
        {
            ZeroKey();
        }
        if (contJ == 0x1c)
        {
            F6();
        }
        if (contJ == 0x1d)
        {
            QstnKey();
        }
        if (contJ == 30)
        {
            QstnKey();
        }
        if (contJ == 0x1f)
        {
            ZeroKey();
        }
        if (contJ == 0x20)
        {
            F9();
        }
        if (contJ == 0x21)
        {
            F9();
        }
        if (contJ == 0x22)
        {
            EightKey();
        }
        if (contJ == 0x23)
        {
            EightKey();
        }
        if (contJ == 0x24)
        {
            F9();
        }
        if (contJ == 0x25)
        {
            ZeroKey();
        }
        if (contJ == 0x26)
        {
            EightKey();
        }
        if (contJ == 0x27)
        {
            SevenKey();
        }
        if (contJ == 40)
        {
            F6();
        }
        if (contJ == 0x29)
        {
            Console.SetCursorPosition(0x43, 0x1f);
            Console.WriteLine("Bell\x00edsimo!!!");
            Console.SetCursorPosition(0x3e, 0x21);
            Console.WriteLine("Toca otra nota para tocar otra canci\x00f3n!!");
        }
        if (contJ == 0x2a)
        {
            contJ = 0;
            Console.Clear();
            FullMenu();
        }
    }

    public static void B1Key()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ _ ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|  _| |_  |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("| | | | | |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("| | | | | |");
        Console.SetCursorPosition(0x43, 0x21);
        Console.WriteLine("|___|_|___|");
    }

    private static void color_key1(int x, bool state)
    {
        if (state)
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.SetCursorPosition((1 + x) + global_x, 1 + global_y);
        Console.WriteLine("  ");
        Console.SetCursorPosition((1 + x) + global_x, 2 + global_y);
        Console.WriteLine("  ");
        Console.SetCursorPosition((1 + x) + global_x, 3 + global_y);
        Console.WriteLine("  ");
        Console.SetCursorPosition((1 + x) + global_x, 4 + global_y);
        Console.WriteLine("  ");
        Console.SetCursorPosition((1 + x) + global_x, 5 + global_y);
        Console.WriteLine("   ");
        Console.SetCursorPosition((1 + x) + global_x, 6 + global_y);
        Console.WriteLine("   ");
    }

    private static void color_key2(int x, bool state)
    {
        if (state)
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
        Console.SetCursorPosition((4 + x) + global_x, 1 + global_y);
        Console.WriteLine(" ");
        Console.SetCursorPosition((4 + x) + global_x, 2 + global_y);
        Console.WriteLine(" ");
        Console.SetCursorPosition((4 + x) + global_x, 3 + global_y);
        Console.WriteLine(" ");
        Console.SetCursorPosition((4 + x) + global_x, 4 + global_y);
        Console.WriteLine(" ");
    }

    private static void color_key3(int x, bool state)
    {
        if (state)
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
        Console.SetCursorPosition((6 + x) + global_x, 1 + global_y);
        Console.WriteLine(" ");
        Console.SetCursorPosition((6 + x) + global_x, 2 + global_y);
        Console.WriteLine(" ");
        Console.SetCursorPosition((6 + x) + global_x, 3 + global_y);
        Console.WriteLine(" ");
        Console.SetCursorPosition((6 + x) + global_x, 4 + global_y);
        Console.WriteLine(" ");
        Console.SetCursorPosition((5 + x) + global_x, 5 + global_y);
        Console.WriteLine("   ");
        Console.SetCursorPosition((5 + x) + global_x, 6 + global_y);
        Console.WriteLine("   ");
    }

    private static void color_key4(int x, bool state)
    {
        if (state)
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
        Console.SetCursorPosition((10 + x) + global_x, 1 + global_y);
        Console.WriteLine("  ");
        Console.SetCursorPosition((10 + x) + global_x, 2 + global_y);
        Console.WriteLine("  ");
        Console.SetCursorPosition((10 + x) + global_x, 3 + global_y);
        Console.WriteLine("  ");
        Console.SetCursorPosition((10 + x) + global_x, 4 + global_y);
        Console.WriteLine("  ");
        Console.SetCursorPosition((9 + x) + global_x, 5 + global_y);
        Console.WriteLine("   ");
        Console.SetCursorPosition((9 + x) + global_x, 6 + global_y);
        Console.WriteLine("   ");
    }

    public static void CucarachaPlay()
    {
        if (contJ == 0)
        {
            FourKey();
        }
        if (contJ == 1)
        {
            FourKey();
        }
        if (contJ == 2)
        {
            FourKey();
        }
        if (contJ == 3)
        {
            SevenKey();
        }
        if (contJ == 4)
        {
            NineKey();
        }
        if (contJ == 5)
        {
            FourKey();
        }
        if (contJ == 6)
        {
            FourKey();
        }
        if (contJ == 7)
        {
            FourKey();
        }
        if (contJ == 8)
        {
            SevenKey();
        }
        if (contJ == 9)
        {
            NineKey();
        }
        if (contJ == 10)
        {
            SevenKey();
        }
        if (contJ == 11)
        {
            SevenKey();
        }
        if (contJ == 12)
        {
            SixKey();
        }
        if (contJ == 13)
        {
            SixKey();
        }
        if (contJ == 14)
        {
            FiveKey();
        }
        if (contJ == 15)
        {
            FiveKey();
        }
        if (contJ == 0x10)
        {
            FourKey();
        }
        if (contJ == 0x11)
        {
            FourKey();
        }
        if (contJ == 0x12)
        {
            FourKey();
        }
        if (contJ == 0x13)
        {
            FourKey();
        }
        if (contJ == 20)
        {
            SixKey();
        }
        if (contJ == 0x15)
        {
            EightKey();
        }
        if (contJ == 0x16)
        {
            FourKey();
        }
        if (contJ == 0x17)
        {
            FourKey();
        }
        if (contJ == 0x18)
        {
            FourKey();
        }
        if (contJ == 0x19)
        {
            SixKey();
        }
        if (contJ == 0x1a)
        {
            EightKey();
        }
        if (contJ == 0x1b)
        {
            QstnKey();
        }
        if (contJ == 0x1c)
        {
            ExclmtnBckKey();
        }
        if (contJ == 0x1d)
        {
            QstnKey();
        }
        if (contJ == 30)
        {
            ZeroKey();
        }
        if (contJ == 0x1f)
        {
            NineKey();
        }
        if (contJ == 0x20)
        {
            EightKey();
        }
        if (contJ == 0x21)
        {
            SevenKey();
        }
        if (contJ == 0x22)
        {
            Console.SetCursorPosition(0x43, 0x1f);
            Console.WriteLine("Magn\x00edfico!!!");
            Console.SetCursorPosition(0x3e, 0x21);
            Console.WriteLine("Toca otra nota para tocar otra canci\x00f3n!!");
        }
        if (contJ == 0x23)
        {
            contJ = 0;
            Console.Clear();
            FullMenu();
        }
    }

    public static void EightKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("| . |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("| . |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|___|");
    }

    public static void ExclmtnBckKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine("   ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|__|");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("|__|");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|  |");
        Console.SetCursorPosition(0x43, 0x21);
        Console.WriteLine("|  |");
        Console.SetCursorPosition(0x43, 0x22);
        Console.WriteLine("|__|");
    }

    public static void F1()
    {
        Fkey();
        OneKey();
    }

    public static void F10()
    {
        Fkey();
        TenKey();
    }

    public static void F11()
    {
        Fkey();
        OneKey();
        OneKey();
    }

    public static void F12()
    {
        Fkey();
        OneKey();
        TwoKey();
    }

    public static void F2()
    {
        Fkey();
        TwoKey();
    }

    public static void F4()
    {
        Fkey();
        FourKey();
    }

    public static void F5()
    {
        Fkey();
        FiveKey();
    }

    public static void F6()
    {
        Fkey();
        SixKey();
    }

    public static void F8()
    {
        Fkey();
        EightKey();
    }

    public static void F9()
    {
        Fkey();
        NineKey();
    }

    public static void FiveKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|  _|");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("|_  |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|___|");
    }

    public static void Fkey()
    {
        Console.SetCursorPosition(60, 0x1d);
        Console.WriteLine(" _____ ");
        Console.SetCursorPosition(60, 30);
        Console.WriteLine("|   __|");
        Console.SetCursorPosition(60, 0x1f);
        Console.WriteLine("|   __|");
        Console.SetCursorPosition(60, 0x20);
        Console.WriteLine("|__|  |");
    }

    public static void Fondo()
    {
        do
        {
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(100);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(0x24b, 100);
            Thread.Sleep(150);
            Console.Beep(0x20b, 100);
            Thread.Sleep(150);
            Console.Beep(440, 100);
            Thread.Sleep(150);
            Console.Beep(0x105, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(440, 100);
            Thread.Sleep(150);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(440, 100);
            Thread.Sleep(150);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(0x20b, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(0x24b, 100);
            Thread.Sleep(150);
            Console.Beep(0x20b, 100);
            Thread.Sleep(150);
            Console.Beep(440, 100);
            Thread.Sleep(150);
            Console.Beep(0x105, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(440, 100);
            Thread.Sleep(150);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(0x20b, 100);
            Thread.Sleep(150);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(440, 100);
            Thread.Sleep(150);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(0x20b, 100);
            Thread.Sleep(150);
            Console.Beep(0x24b, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x188, 100);
            Thread.Sleep(150);
            Console.Beep(0x2ba, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x24b, 100);
            Thread.Sleep(150);
            Console.Beep(0x15d, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x24b, 100);
            Thread.Sleep(150);
            Console.Beep(0x20b, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(0x24b, 100);
            Thread.Sleep(150);
            Console.Beep(0x20b, 100);
            Thread.Sleep(150);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x149, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x26e, 100);
            Thread.Sleep(150);
            Console.Beep(0x293, 100);
            Thread.Sleep(150);
            Console.Beep(0x1ed, 100);
            Thread.Sleep(150);
            Console.Beep(0x24b, 100);
            Thread.Sleep(150);
            Console.Beep(0x20b, 100);
            Thread.Sleep(150);
            Console.Beep(440, 100);
        }
        while (cont < 2);
    }

    public static void FourKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("| | |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("|_  |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("  |_|");
    }

    public static void FullMenu()
    {
        Console.SetWindowSize(150, 0x31);
        Console.SetBufferSize(0x99, 0x35);
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("                                                                                                                                                       ");
        Console.WriteLine("                   __                  _                                                                                                               ");
        Console.WriteLine("                  /  )                //                                                                                                               ");
        Console.WriteLine("                 /   __ ____  _   __ // _                              ╔════════════════════════════════════════════════════════════╗                  ");
        Console.WriteLine("                (__/(_)/ / <_/_)_(_)</_</_                             ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                  ____                                                 ║                                                            ║                  ");
        Console.WriteLine("                 ' )  )                                                ║                                                            ║                  ");
        Console.WriteLine("                  /--'o __.  ____  __                                  ║                                                            ║                  ");
        Console.WriteLine("                 /   <_(_/|_/ / <_(_)                                  ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                 \x00a1Oprima Enter Para Empezar!                           ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                  ");
        Console.WriteLine("                                                                       ║                                                            ║                 ");
        Console.WriteLine("               __________________________________                      ║                                                            ║                 ");
        Console.WriteLine("              /                                  /                     ║                                                            ║                 ");
        Console.WriteLine("             /                                    /_________           ║                                                            ║                 ");
        Console.WriteLine("            /                                                /         ║                                                            ║                 ");
        Console.WriteLine("           /                                                  /        ║                                                            ║                 ");
        Console.WriteLine("          /                                                    /       ║                                                            ║                 ");
        Console.WriteLine("         /                                                      /      ║                                                            ║                 ");
        Console.WriteLine("        /                _______________                        |      ║                                                            ║                 ");
        Console.WriteLine("       / Raul Alberto   |       |       | Console Piano V 1.0  /|      ║                                                            ║                 ");
        Console.WriteLine("      / Navarrete       |=======+=======| Ing. en Software    / |      ║                                                            ║                 ");
        Console.WriteLine("     / Novelo      ...  |_______|_______| UPQROO             /  |      ║                                                            ║                 ");
        Console.WriteLine("    / _______________________________________________________/   |     ╚════════════════════════════════════════════════════════════╝                 ");
        Console.WriteLine("    |                                                       |   /                                                                                     ");
        Console.WriteLine("    |   _   _       _   _   _ RALE  _   _       _   _   _   |  /                                                                                      ");
        Console.WriteLine("    | __//|_//|_____//|_//|_//|_____//|_//|_____//|_//|_//|__| /                                                                                      ");
        Console.WriteLine("   /  /// ///  /  /// /// ///  /  /// ///  /  /// /// ///  / /                                                                                        ");
        Console.WriteLine("  /  ||/ ||/  /  ||/ ||/ ||/  /  ||/ ||/  /  ||/ ||/ ||/  / /                                                                                         ");
        Console.WriteLine(" / ___/___/___/___/___/___/___/___/___/___/___/___/___/___/ /                                                                                         ");
        Console.WriteLine(" | ___|___|___|___|___|___|___|___|___|___|___|___|___|___|/                                                                                          ");
        Console.WriteLine("        /   /                                 /   /                                                                                                   ");
        Console.WriteLine("         | ||                                  | ||                                                                                                   ");
        Console.WriteLine("         | ||                                  | ||                                                                                                   ");
        Console.WriteLine("         | _|/        Console Piano              |_|/ ____________________________________                                                            ");
        Console.WriteLine("                                                                                                                                                      ");
        Console.WriteLine("                                                                                                                                                      ");
        Console.WriteLine("                                                                                                                                                      ");
        Console.WriteLine("                                                                                                                                                      ");
        Console.WriteLine("                                                                                                                                                      ");
        Console.WriteLine("                                                                                                                                                      ");
        k = Console.ReadKey(true);
        if (k.Key == ConsoleKey.Enter)
        {
            Console.SetCursorPosition(0x11, 0x11);
            Console.WriteLine("\x00a1Elige una canci\x00f3n!        ");
            Songs();
            do
            {
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.DownArrow)
                {
                    contmenu++;
                }
                if (k.Key == ConsoleKey.UpArrow)
                {
                    contmenu--;
                }
                if (contmenu == 6)
                {
                    contmenu = 0;
                }
                if (contmenu == -1)
                {
                    contmenu = 5;
                }
                Console.SetCursorPosition(90, 30);
                Console.WriteLine(contmenu);
                switch (contmenu)
                {
                    case 0:
                        Songs();
                        if (k.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            thread1.Abort();
                            PianoEngineMarcha();
                        }
                        break;

                    case 1:
                        MenuCucaracha();
                        if (k.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            thread1.Abort();
                            PianoEngineCucaracha();
                        }
                        break;

                    case 2:
                        MenuFurElise();
                        if (k.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            thread1.Abort();
                            PianoEngineFurElise();
                        }
                        break;

                    case 3:
                        MenuHabanera();
                        if (k.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            thread1.Abort();
                            PianoEngineHabanera();
                        }
                        break;

                    case 4:
                        MenuAmerica();
                        if (k.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            thread1.Abort();
                            PianoEngineAmerica();
                        }
                        break;

                    case 5:
                        MenuFreeplay();
                        if (k.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            thread1.Abort();
                            PianoEngineFreeplay();
                        }
                        break;
                }
            }
            while (k.Key != ConsoleKey.Escape);
        }
    }

    public static void FurElisePlay()
    {
        if (contJ == 0)
        {
            NineKey();
        }
        if (contJ == 1)
        {
            F9();
        }
        if (contJ == 2)
        {
            NineKey();
        }
        if (contJ == 3)
        {
            F9();
        }
        if (contJ == 4)
        {
            NineKey();
        }
        if (contJ == 5)
        {
            SixKey();
        }
        if (contJ == 6)
        {
            EightKey();
        }
        if (contJ == 7)
        {
            SevenKey();
        }
        if (contJ == 8)
        {
            FiveKey();
        }
        if (contJ == 9)
        {
            B1Key();
        }
        if (contJ == 10)
        {
            TwoKey();
        }
        if (contJ == 11)
        {
            FiveKey();
        }
        if (contJ == 12)
        {
            SixKey();
        }
        if (contJ == 13)
        {
            TwoKey();
        }
        if (contJ == 14)
        {
            F5();
        }
        if (contJ == 15)
        {
            SixKey();
        }
        if (contJ == 0x10)
        {
            SevenKey();
        }
        if (contJ == 0x11)
        {
            TwoKey();
        }
        if (contJ == 0x12)
        {
            NineKey();
        }
        if (contJ == 0x13)
        {
            F9();
        }
        if (contJ == 20)
        {
            NineKey();
        }
        if (contJ == 0x15)
        {
            F9();
        }
        if (contJ == 0x16)
        {
            NineKey();
        }
        if (contJ == 0x17)
        {
            SixKey();
        }
        if (contJ == 0x18)
        {
            EightKey();
        }
        if (contJ == 0x19)
        {
            SevenKey();
        }
        if (contJ == 0x1a)
        {
            FiveKey();
        }
        if (contJ == 0x1b)
        {
            B1Key();
        }
        if (contJ == 0x1c)
        {
            TwoKey();
        }
        if (contJ == 0x1d)
        {
            FiveKey();
        }
        if (contJ == 30)
        {
            SixKey();
        }
        if (contJ == 0x1f)
        {
            TwoKey();
        }
        if (contJ == 0x20)
        {
            SevenKey();
        }
        if (contJ == 0x21)
        {
            SixKey();
        }
        if (contJ == 0x22)
        {
            FiveKey();
        }
        if (contJ == 0x23)
        {
            SixKey();
        }
        if (contJ == 0x22)
        {
            SevenKey();
        }
        if (contJ == 0x24)
        {
            EightKey();
        }
        if (contJ == 0x25)
        {
            NineKey();
        }
        if (contJ == 0x26)
        {
            FourKey();
        }
        if (contJ == 0x27)
        {
            ZeroKey();
        }
        if (contJ == 40)
        {
            NineKey();
        }
        if (contJ == 0x29)
        {
            EightKey();
        }
        if (contJ == 0x2a)
        {
            ThreeKey();
        }
        if (contJ == 0x2b)
        {
            NineKey();
        }
        if (contJ == 0x2c)
        {
            EightKey();
        }
        if (contJ == 0x2d)
        {
            SevenKey();
        }
        if (contJ == 0x2e)
        {
            TwoKey();
        }
        if (contJ == 0x2f)
        {
            EightKey();
        }
        if (contJ == 0x30)
        {
            SevenKey();
        }
        if (contJ == 0x31)
        {
            SixKey();
        }
        if (contJ == 50)
        {
            TwoKey();
        }
        if (contJ == 0x33)
        {
            TwoKey();
        }
        if (contJ == 0x34)
        {
            NineKey();
        }
        if (contJ == 0x35)
        {
            TwoKey();
        }
        if (contJ == 0x36)
        {
            NineKey();
        }
        if (contJ == 0x37)
        {
            NineKey();
        }
        if (contJ == 0x38)
        {
            F9();
        }
        if (contJ == 0x39)
        {
            NineKey();
        }
        if (contJ == 0x3a)
        {
            F9();
        }
        if (contJ == 0x3b)
        {
            NineKey();
        }
        if (contJ == 60)
        {
            F9();
        }
        if (contJ == 0x3d)
        {
            NineKey();
        }
        if (contJ == 0x3e)
        {
            F9();
        }
        if (contJ == 0x3f)
        {
            NineKey();
        }
        if (contJ == 0x40)
        {
            F9();
        }
        if (contJ == 0x41)
        {
            NineKey();
        }
        if (contJ == 0x42)
        {
            F9();
        }
        if (contJ == 0x43)
        {
            NineKey();
        }
        if (contJ == 0x44)
        {
            SixKey();
        }
        if (contJ == 0x45)
        {
            EightKey();
        }
        if (contJ == 70)
        {
            SevenKey();
        }
        if (contJ == 0x47)
        {
            FiveKey();
        }
        if (contJ == 0x48)
        {
            Console.SetCursorPosition(0x43, 0x1f);
            Console.WriteLine("Magn\x00edfica presentaci\x00f3n");
            Console.SetCursorPosition(0x3e, 0x21);
            Console.WriteLine("Toca otra nota para tocar otra canci\x00f3n!!");
        }
        if (contJ == 0x49)
        {
            contJ = 0;
            Console.Clear();
            FullMenu();
        }
    }

    public static void HabaneraPlay()
    {
        Console.WriteLine(contJ);
        if (contJ == 0)
        {
            EightKey();
        }
        if (contJ == 1)
        {
            F8();
        }
        if (contJ == 2)
        {
            SevenKey();
        }
        if (contJ == 3)
        {
            SevenKey();
        }
        if (contJ == 4)
        {
            SevenKey();
        }
        if (contJ == 5)
        {
            SevenKey();
        }
        if (contJ == 6)
        {
            SixKey();
        }
        if (contJ == 7)
        {
            F6();
        }
        if (contJ == 8)
        {
            FiveKey();
        }
        if (contJ == 9)
        {
            FiveKey();
        }
        if (contJ == 10)
        {
            FourKey();
        }
        if (contJ == 11)
        {
            ThreeKey();
        }
        if (contJ == 12)
        {
            TwoKey();
        }
        if (contJ == 13)
        {
            TwoKey();
        }
        if (contJ == 14)
        {
            ThreeKey();
        }
        if (contJ == 15)
        {
            TwoKey();
        }
        if (contJ == 0x10)
        {
            OneKey();
        }
        if (contJ == 0x11)
        {
            TwoKey();
        }
        if (contJ == 0x12)
        {
            FourKey();
        }
        if (contJ == 0x13)
        {
            ThreeKey();
        }
        if (contJ == 20)
        {
            TwoKey();
        }
        if (contJ == 0x15)
        {
            EightKey();
        }
        if (contJ == 0x16)
        {
            F8();
        }
        if (contJ == 0x17)
        {
            SevenKey();
        }
        if (contJ == 0x18)
        {
            SevenKey();
        }
        if (contJ == 0x19)
        {
            SevenKey();
        }
        if (contJ == 0x1a)
        {
            SevenKey();
        }
        if (contJ == 0x1b)
        {
            SixKey();
        }
        if (contJ == 0x1c)
        {
            F6();
        }
        if (contJ == 0x1d)
        {
            FiveKey();
        }
        if (contJ == 30)
        {
            FiveKey();
        }
        if (contJ == 0x1f)
        {
            FourKey();
        }
        if (contJ == 0x20)
        {
            ThreeKey();
        }
        if (contJ == 0x21)
        {
            TwoKey();
        }
        if (contJ == 0x22)
        {
            ThreeKey();
        }
        if (contJ == 0x23)
        {
            TwoKey();
        }
        if (contJ == 0x22)
        {
            OneKey();
        }
        if (contJ == 0x24)
        {
            TwoKey();
        }
        if (contJ == 0x25)
        {
            ThreeKey();
        }
        if (contJ == 0x26)
        {
            TwoKey();
        }
        if (contJ == 0x27)
        {
            OneKey();
        }
        if (contJ == 40)
        {
            FiveKey();
        }
        if (contJ == 0x29)
        {
            OneKey();
        }
        if (contJ == 0x2a)
        {
            TwoKey();
        }
        if (contJ == 0x2b)
        {
            F4();
        }
        if (contJ == 0x2c)
        {
            FiveKey();
        }
        if (contJ == 0x2d)
        {
            F4();
        }
        if (contJ == 0x2e)
        {
            TwoKey();
        }
        if (contJ == 0x2f)
        {
            OneKey();
        }
        if (contJ == 0x30)
        {
            TwoKey();
        }
        if (contJ == 0x31)
        {
            F4();
        }
        if (contJ == 50)
        {
            FourKey();
        }
        if (contJ == 0x33)
        {
            FiveKey();
        }
        if (contJ == 0x34)
        {
            FiveKey();
        }
        if (contJ == 0x35)
        {
            FiveKey();
        }
        if (contJ == 0x36)
        {
            FiveKey();
        }
        if (contJ == 0x37)
        {
            SixKey();
        }
        if (contJ == 0x38)
        {
            FiveKey();
        }
        if (contJ == 0x39)
        {
            FourKey();
        }
        if (contJ == 0x3a)
        {
            SixKey();
        }
        if (contJ == 0x3b)
        {
            TwoKey();
        }
        if (contJ == 60)
        {
            F4();
        }
        if (contJ == 0x3d)
        {
            FourKey();
        }
        if (contJ == 0x3e)
        {
            SixKey();
        }
        if (contJ == 0x3f)
        {
            FourKey();
        }
        if (contJ == 0x40)
        {
            F4();
        }
        if (contJ == 0x41)
        {
            TwoKey();
        }
        if (contJ == 0x42)
        {
            F4();
        }
        if (contJ == 0x43)
        {
            FourKey();
        }
        if (contJ == 0x44)
        {
            FiveKey();
        }
        if (contJ == 0x45)
        {
            SixKey();
        }
        if (contJ == 70)
        {
            SixKey();
        }
        if (contJ == 0x47)
        {
            SixKey();
        }
        if (contJ == 0x48)
        {
            SixKey();
        }
        if (contJ == 0x49)
        {
            F8();
        }
        if (contJ == 0x4a)
        {
            SixKey();
        }
        if (contJ == 0x4b)
        {
            FiveKey();
        }
        if (contJ == 0x4c)
        {
            FiveKey();
        }
        if (contJ == 0x4d)
        {
            OneKey();
        }
        if (contJ == 0x4e)
        {
            TwoKey();
        }
        if (contJ == 0x4f)
        {
            F4();
        }
        if (contJ == 80)
        {
            FiveKey();
        }
        if (contJ == 0x51)
        {
            F4();
        }
        if (contJ == 0x52)
        {
            TwoKey();
        }
        if (contJ == 0x53)
        {
            OneKey();
        }
        if (contJ == 0x54)
        {
            TwoKey();
        }
        if (contJ == 0x55)
        {
            F4();
        }
        if (contJ == 0x56)
        {
            FourKey();
        }
        if (contJ == 0x57)
        {
            FiveKey();
        }
        if (contJ == 0x58)
        {
            FiveKey();
        }
        if (contJ == 0x59)
        {
            FiveKey();
        }
        if (contJ == 90)
        {
            FiveKey();
        }
        if (contJ == 0x5b)
        {
            EightKey();
        }
        if (contJ == 0x5c)
        {
            F8();
        }
        if (contJ == 0x5d)
        {
            F8();
        }
        if (contJ == 0x5e)
        {
            SixKey();
        }
        if (contJ == 0x5f)
        {
            TwoKey();
        }
        if (contJ == 0x60)
        {
            F4();
        }
        if (contJ == 0x61)
        {
            FourKey();
        }
        if (contJ == 0x62)
        {
            SixKey();
        }
        if (contJ == 0x63)
        {
            FourKey();
        }
        if (contJ == 100)
        {
            F4();
        }
        if (contJ == 0x65)
        {
            TwoKey();
        }
        if (contJ == 0x66)
        {
            F4();
        }
        if (contJ == 0x67)
        {
            FourKey();
        }
        if (contJ == 0x68)
        {
            FiveKey();
        }
        if (contJ == 0x69)
        {
            F8();
        }
        if (contJ == 0x6a)
        {
            SixKey();
        }
        if (contJ == 0x6b)
        {
            F5();
        }
        if (contJ == 0x6c)
        {
            FiveKey();
        }
        if (contJ == 0x6d)
        {
            F10();
        }
        if (contJ == 110)
        {
            NineKey();
        }
        if (contJ == 0x6f)
        {
            EightKey();
        }
        if (contJ == 0x70)
        {
            Console.SetCursorPosition(0x43, 0x1f);
            Console.WriteLine("Bell\x00edsimo!!!");
            Console.SetCursorPosition(0x3e, 0x21);
            Console.WriteLine("Toca otra nota para tocar otra canci\x00f3n!!");
        }
        if (contJ == 0x71)
        {
            contJ = 0;
            Console.Clear();
            FullMenu();
        }
    }

    public static void Main()
    {
        thread1.Start();
        FullMenu();
    }

    public static void MarchaPlay()
    {
        if (contJ == 0)
        {
            FourKey();
        }
        if (contJ == 1)
        {
            SevenKey();
        }
        if (contJ == 2)
        {
            SevenKey();
        }
        if (contJ == 3)
        {
            SevenKey();
        }
        if (contJ == 4)
        {
            FourKey();
        }
        if (contJ == 5)
        {
            EightKey();
        }
        if (contJ == 6)
        {
            SixKey();
        }
        if (contJ == 7)
        {
            SevenKey();
        }
        if (contJ == 8)
        {
            FourKey();
        }
        if (contJ == 9)
        {
            SevenKey();
        }
        if (contJ == 10)
        {
            ZeroKey();
        }
        if (contJ == 11)
        {
            ZeroKey();
        }
        if (contJ == 12)
        {
            NineKey();
        }
        if (contJ == 13)
        {
            EightKey();
        }
        if (contJ == 14)
        {
            SevenKey();
        }
        if (contJ == 15)
        {
            SixKey();
        }
        if (contJ == 0x10)
        {
            SevenKey();
        }
        if (contJ == 0x11)
        {
            EightKey();
        }
        if (contJ == 0x12)
        {
            FourKey();
        }
        if (contJ == 0x13)
        {
            SevenKey();
        }
        if (contJ == 20)
        {
            SevenKey();
        }
        if (contJ == 0x15)
        {
            SevenKey();
        }
        if (contJ == 0x16)
        {
            FourKey();
        }
        if (contJ == 0x17)
        {
            EightKey();
        }
        if (contJ == 0x18)
        {
            SixKey();
        }
        if (contJ == 0x19)
        {
            SevenKey();
        }
        if (contJ == 0x1a)
        {
            FourKey();
        }
        if (contJ == 0x1b)
        {
            SevenKey();
        }
        if (contJ == 0x1c)
        {
            NineKey();
        }
        if (contJ == 0x1d)
        {
            QstnKey();
        }
        if (contJ == 30)
        {
            NineKey();
        }
        if (contJ == 0x1f)
        {
            SevenKey();
        }
        if (contJ == 0x20)
        {
            FiveKey();
        }
        if (contJ == 0x21)
        {
            EightKey();
        }
        if (contJ == 0x22)
        {
            NineKey();
        }
        if (contJ == 0x23)
        {
            SevenKey();
        }
        if (contJ == 0x24)
        {
            Console.SetCursorPosition(0x43, 0x1f);
            Console.WriteLine("Virtuoso!!!");
            Console.SetCursorPosition(0x3e, 0x20);
            Console.WriteLine("Toca otra nota para tocar otra canci\x00f3n!!");
        }
        if (contJ == 0x25)
        {
            Console.Clear();
            contJ = 0;
            Console.Clear();
            FullMenu();
        }
    }

    public static void MenuAmerica()
    {
        Console.SetCursorPosition(0x51, 8);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Marcha);
        Console.SetCursorPosition(0x51, 11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Cucaracha);
        Console.SetCursorPosition(0x51, 14);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(FurElise);
        Console.SetCursorPosition(0x51, 0x11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Habanera);
        Console.SetCursorPosition(0x51, 20);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(America);
        Console.SetCursorPosition(0x51, 0x17);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Freeplay);
    }

    public static void MenuCucaracha()
    {
        Console.SetCursorPosition(0x51, 8);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Marcha);
        Console.SetCursorPosition(0x51, 11);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Cucaracha);
        Console.SetCursorPosition(0x51, 14);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(FurElise);
        Console.SetCursorPosition(0x51, 0x11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Habanera);
        Console.SetCursorPosition(0x51, 20);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(America);
        Console.SetCursorPosition(0x51, 0x17);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Freeplay);
    }

    public static void MenuFreeplay()
    {
        Console.SetCursorPosition(0x51, 8);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Marcha);
        Console.SetCursorPosition(0x51, 11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Cucaracha);
        Console.SetCursorPosition(0x51, 14);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(FurElise);
        Console.SetCursorPosition(0x51, 0x11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Habanera);
        Console.SetCursorPosition(0x51, 20);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(America);
        Console.SetCursorPosition(0x51, 0x17);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Freeplay);
    }

    public static void MenuFurElise()
    {
        Console.SetCursorPosition(0x51, 8);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Marcha);
        Console.SetCursorPosition(0x51, 11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Cucaracha);
        Console.SetCursorPosition(0x51, 14);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(FurElise);
        Console.SetCursorPosition(0x51, 0x11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Habanera);
        Console.SetCursorPosition(0x51, 20);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(America);
        Console.SetCursorPosition(0x51, 0x17);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Freeplay);
    }

    public static void MenuHabanera()
    {
        Console.SetCursorPosition(0x51, 8);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Marcha);
        Console.SetCursorPosition(0x51, 11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Cucaracha);
        Console.SetCursorPosition(0x51, 14);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(FurElise);
        Console.SetCursorPosition(0x51, 0x11);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Habanera);
        Console.SetCursorPosition(0x51, 20);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(America);
        Console.SetCursorPosition(0x51, 0x17);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Freeplay);
    }

    public static void NineKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("| . |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("|_  |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|___|");
    }

    public static void OneKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___  ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|_  | ");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine(" _| |_");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|_____|");
    }

    public static void PianoEngineAmerica()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: | America the Beautiful                                                                                                                          | :|");
        Console.WriteLine("|: | Katherine Lee Bates                                                                                                                        | :|");
        Console.WriteLine("|: | (1845)                                                                                                                                     | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine(T1);
        Console.WriteLine(T2);
        Console.WriteLine(T3);
        Console.WriteLine(T4);
        Console.WriteLine(T5);
        Console.WriteLine(T6);
        Console.WriteLine(T7);
        Console.WriteLine(T8);
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                        Oprime Enter para tocar!!                                                           | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        do
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            k = Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: | America the Beautiful                                                                                                                          | :|");
            Console.WriteLine("|: | Katharine Lee Bates                                                                                                                        | :|");
            Console.WriteLine("|: | (1842)                                                                                                                                     | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T1);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T2);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T3);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T4);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T5);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T6);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T7);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T8);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            AmericaPlay();
            if (k.Key == ConsoleKey.Oem5)
            {
                color_key1(0, true);
                Console.Beep(0x105, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D1)
            {
                color_key3(0, true);
                Console.Beep(0x125, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D2)
            {
                color_key4(0, true);
                Console.Beep(0x149, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D3)
            {
                color_key1(12, true);
                Console.Beep(0x15d, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D4)
            {
                color_key3(12, true);
                Console.Beep(0x188, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D5)
            {
                color_key3(0x10, true);
                Console.Beep(440, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D6)
            {
                color_key4(0x10, true);
                Console.Beep(0x1ed, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D7)
            {
                color_key1(0x1c, true);
                Console.Beep(0x20b, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D8)
            {
                color_key3(0x1c, true);
                Console.Beep(0x24b, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D9)
            {
                color_key4(0x1c, true);
                Console.Beep(0x293, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D0)
            {
                color_key1(40, true);
                Console.Beep(0x2ba, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Oem4)
            {
                color_key3(40, true);
                Console.Beep(0x310, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Oem6)
            {
                color_key3(0x2c, true);
                Console.Beep(880, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Backspace)
            {
                color_key4(0x2c, true);
                Console.Beep(0x3da, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F1)
            {
                color_key2(0, true);
                Console.Beep(0x115, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F2)
            {
                color_key2(4, true);
                Console.Beep(0x137, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F4)
            {
                color_key2(12, true);
                Console.Beep(370, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F5)
            {
                color_key2(0x10, true);
                Console.Beep(0x19f, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F6)
            {
                color_key2(20, true);
                Console.Beep(0x1d2, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F8)
            {
                color_key2(0x1c, true);
                Console.Beep(0x22a, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F9)
            {
                color_key2(0x20, true);
                Console.Beep(0x26e, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F10)
            {
                color_key2(40, true);
                Console.Beep(740, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F11)
            {
                color_key2(0x2c, true);
                Console.Beep(830, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F12)
            {
                color_key2(0x30, true);
                Console.Beep(0x3a4, 100);
                contJ++;
            }
        }
        while (cont < 2);
    }

    public static void PianoEngineCucaracha()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: | La Cucaracha                                                                                                                               | :|");
        Console.WriteLine("|: | Francisco Rodriguez Mar\x00edn                                                                                                                  | :|");
        Console.WriteLine("|: | (1818)                                                                                                                                     | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine(T1);
        Console.WriteLine(T2);
        Console.WriteLine(T3);
        Console.WriteLine(T4);
        Console.WriteLine(T5);
        Console.WriteLine(T6);
        Console.WriteLine(T7);
        Console.WriteLine(T8);
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                   Oprime Enter para tocar!!                                                                | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        do
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            k = Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: | La Cucaracha                                                                                                                               | :|");
            Console.WriteLine("|: | Francisco Rodriguez Mar\x00edn                                                                                                                  | :|");
            Console.WriteLine("|: | (1818)                                                                                                                                     | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T1);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T2);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T3);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T4);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T5);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T6);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T7);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T8);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            CucarachaPlay();
            if (k.Key == ConsoleKey.Oem5)
            {
                color_key1(0, true);
                Console.Beep(0x105, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D1)
            {
                color_key3(0, true);
                Console.Beep(0x125, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D2)
            {
                color_key4(0, true);
                Console.Beep(0x149, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D3)
            {
                color_key1(12, true);
                Console.Beep(0x15d, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D4)
            {
                color_key3(12, true);
                Console.Beep(0x188, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D5)
            {
                color_key3(0x10, true);
                Console.Beep(440, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D6)
            {
                color_key4(0x10, true);
                Console.Beep(0x1ed, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D7)
            {
                color_key1(0x1c, true);
                Console.Beep(0x20b, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D8)
            {
                color_key3(0x1c, true);
                Console.Beep(0x24b, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D9)
            {
                color_key4(0x1c, true);
                Console.Beep(0x293, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D0)
            {
                color_key1(40, true);
                Console.Beep(0x2ba, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Oem4)
            {
                color_key3(40, true);
                Console.Beep(0x310, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Oem6)
            {
                color_key3(0x2c, true);
                Console.Beep(880, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Backspace)
            {
                color_key4(0x2c, true);
                Console.Beep(0x3da, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F1)
            {
                color_key2(0, true);
                Console.Beep(0x115, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F2)
            {
                color_key2(4, true);
                Console.Beep(0x137, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F4)
            {
                color_key2(12, true);
                Console.Beep(370, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F5)
            {
                color_key2(0x10, true);
                Console.Beep(0x19f, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F6)
            {
                color_key2(20, true);
                Console.Beep(0x1d2, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F8)
            {
                color_key2(0x1c, true);
                Console.Beep(0x22a, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F9)
            {
                color_key2(0x20, true);
                Console.Beep(0x26e, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F10)
            {
                color_key2(40, true);
                Console.Beep(740, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F11)
            {
                color_key2(0x2c, true);
                Console.Beep(830, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F12)
            {
                color_key2(0x30, true);
                Console.Beep(0x3a4, 100);
                contJ++;
            }
        }
        while (cont < 2);
    }

    public static void PianoEngineFreeplay()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: | \x00a1Bienvenido al modo Freeplay!                                                                                                              | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: | Toca lo que gustes, impresiona a tu audiencia.                                                                                             | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine(T1);
        Console.WriteLine(T2);
        Console.WriteLine(T3);
        Console.WriteLine(T4);
        Console.WriteLine(T5);
        Console.WriteLine(T6);
        Console.WriteLine(T7);
        Console.WriteLine(T8);
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                        Oprime Enter para tocar!!                                                           | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        do
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            k = Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: | \x00a1Bienvenido al modo Freeplay!                                                                                                              | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: | Toca lo que gustes, impresiona a tu audiencia.                                                                                             | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T1);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T2);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T3);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T4);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T5);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T6);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T7);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T8);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            if (k.Key == ConsoleKey.Oem5)
            {
                color_key1(0, true);
                Console.Beep(0x105, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D1)
            {
                color_key3(0, true);
                Console.Beep(0x125, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D2)
            {
                color_key4(0, true);
                Console.Beep(0x149, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D3)
            {
                color_key1(12, true);
                Console.Beep(0x15d, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D4)
            {
                color_key3(12, true);
                Console.Beep(0x188, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D5)
            {
                color_key3(0x10, true);
                Console.Beep(440, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D6)
            {
                color_key4(0x10, true);
                Console.Beep(0x1ed, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D7)
            {
                color_key1(0x1c, true);
                Console.Beep(0x20b, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D8)
            {
                color_key3(0x1c, true);
                Console.Beep(0x24b, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D9)
            {
                color_key4(0x1c, true);
                Console.Beep(0x293, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D0)
            {
                color_key1(40, true);
                Console.Beep(0x2ba, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Oem4)
            {
                color_key3(40, true);
                Console.Beep(0x310, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Oem6)
            {
                color_key3(0x2c, true);
                Console.Beep(880, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Backspace)
            {
                color_key4(0x2c, true);
                Console.Beep(0x3da, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F1)
            {
                color_key2(0, true);
                Console.Beep(0x115, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F2)
            {
                color_key2(4, true);
                Console.Beep(0x137, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F4)
            {
                color_key2(12, true);
                Console.Beep(370, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F5)
            {
                color_key2(0x10, true);
                Console.Beep(0x19f, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F6)
            {
                color_key2(20, true);
                Console.Beep(0x1d2, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F8)
            {
                color_key2(0x1c, true);
                Console.Beep(0x22a, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F9)
            {
                color_key2(0x20, true);
                Console.Beep(0x26e, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F10)
            {
                color_key2(40, true);
                Console.Beep(740, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F11)
            {
                color_key2(0x2c, true);
                Console.Beep(830, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F12)
            {
                color_key2(0x30, true);
                Console.Beep(0x3a4, 100);
                contJ++;
            }
        }
        while (cont < 2);
    }

    public static void PianoEngineFurElise()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Clear();
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: | F\x00fcr Elise                                                                                                                                  | :|");
        Console.WriteLine("|: | Ludwig van Beethoven                                                                                                                       | :|");
        Console.WriteLine("|: | (1810)                                                                                                                                     | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine(T1);
        Console.WriteLine(T2);
        Console.WriteLine(T3);
        Console.WriteLine(T4);
        Console.WriteLine(T5);
        Console.WriteLine(T6);
        Console.WriteLine(T7);
        Console.WriteLine(T8);
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                Oprime Enter para tocar!!                                                                   | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        do
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            ConsoleKeyInfo info = Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: | F\x00fcr Elise                                                                                                                                  | :|");
            Console.WriteLine("|: | Ludwig van Beethoven                                                                                                                       | :|");
            Console.WriteLine("|: | (1810)                                                                                                                                     | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T1);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T2);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T3);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T4);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T5);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T6);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T7);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T8);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            FurElisePlay();
            if (info.Key == ConsoleKey.Oem5)
            {
                color_key1(0, true);
                Console.Beep(0x105, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D1)
            {
                color_key3(0, true);
                Console.Beep(0x125, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D2)
            {
                color_key4(0, true);
                Console.Beep(0x149, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D3)
            {
                color_key1(12, true);
                Console.Beep(0x15d, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D4)
            {
                color_key3(12, true);
                Console.Beep(0x188, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D5)
            {
                color_key3(0x10, true);
                Console.Beep(440, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D6)
            {
                color_key4(0x10, true);
                Console.Beep(0x1ed, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D7)
            {
                color_key1(0x1c, true);
                Console.Beep(0x20b, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D8)
            {
                color_key3(0x1c, true);
                Console.Beep(0x24b, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D9)
            {
                color_key4(0x1c, true);
                Console.Beep(0x293, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D0)
            {
                color_key1(40, true);
                Console.Beep(0x2ba, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.Oem4)
            {
                color_key3(40, true);
                Console.Beep(0x310, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.Oem6)
            {
                color_key3(0x2c, true);
                Console.Beep(880, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.Backspace)
            {
                color_key4(0x2c, true);
                Console.Beep(0x3da, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F1)
            {
                color_key2(0, true);
                Console.Beep(0x115, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F2)
            {
                color_key2(4, true);
                Console.Beep(0x137, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F4)
            {
                color_key2(12, true);
                Console.Beep(370, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F5)
            {
                color_key2(0x10, true);
                Console.Beep(0x19f, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F6)
            {
                color_key2(20, true);
                Console.Beep(0x1d2, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F8)
            {
                color_key2(0x1c, true);
                Console.Beep(0x22a, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F9)
            {
                color_key2(0x20, true);
                Console.Beep(0x26e, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F10)
            {
                color_key2(40, true);
                Console.Beep(740, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F11)
            {
                color_key2(0x2c, true);
                Console.Beep(830, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F12)
            {
                color_key2(0x30, true);
                Console.Beep(0x3a4, 100);
                contJ++;
            }
        }
        while (cont < 2);
    }

    public static void PianoEngineHabanera()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: | Habanera                                                                                                                                   | :|");
        Console.WriteLine("|: | Georges Bizet                                                                                                                              | :|");
        Console.WriteLine("|: | (1845)                                                                                                                                     | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine(T1);
        Console.WriteLine(T2);
        Console.WriteLine(T3);
        Console.WriteLine(T4);
        Console.WriteLine(T5);
        Console.WriteLine(T6);
        Console.WriteLine(T7);
        Console.WriteLine(T8);
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                        Oprime Enter para tocar!!                                                           | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        do
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            k = Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: | Habanera                                                                                                                                   | :|");
            Console.WriteLine("|: | Georges Bizet                                                                                                                              | :|");
            Console.WriteLine("|: | (1845)                                                                                                                                     | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T1);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T2);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T3);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T4);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T5);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T6);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T7);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T8);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            HabaneraPlay();
            if (k.Key == ConsoleKey.Oem5)
            {
                color_key1(0, true);
                Console.Beep(0x105, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D1)
            {
                color_key3(0, true);
                Console.Beep(0x125, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D2)
            {
                color_key4(0, true);
                Console.Beep(0x149, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D3)
            {
                color_key1(12, true);
                Console.Beep(0x15d, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D4)
            {
                color_key3(12, true);
                Console.Beep(0x188, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D5)
            {
                color_key3(0x10, true);
                Console.Beep(440, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D6)
            {
                color_key4(0x10, true);
                Console.Beep(0x1ed, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D7)
            {
                color_key1(0x1c, true);
                Console.Beep(0x20b, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D8)
            {
                color_key3(0x1c, true);
                Console.Beep(0x24b, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D9)
            {
                color_key4(0x1c, true);
                Console.Beep(0x293, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.D0)
            {
                color_key1(40, true);
                Console.Beep(0x2ba, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Oem4)
            {
                color_key3(40, true);
                Console.Beep(0x310, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Oem6)
            {
                color_key3(0x2c, true);
                Console.Beep(880, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.Backspace)
            {
                color_key4(0x2c, true);
                Console.Beep(0x3da, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F1)
            {
                color_key2(0, true);
                Console.Beep(0x115, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F2)
            {
                color_key2(4, true);
                Console.Beep(0x137, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F4)
            {
                color_key2(12, true);
                Console.Beep(370, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F5)
            {
                color_key2(0x10, true);
                Console.Beep(0x19f, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F6)
            {
                color_key2(20, true);
                Console.Beep(0x1d2, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F8)
            {
                color_key2(0x1c, true);
                Console.Beep(0x22a, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F9)
            {
                color_key2(0x20, true);
                Console.Beep(0x26e, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F10)
            {
                color_key2(40, true);
                Console.Beep(740, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F11)
            {
                color_key2(0x2c, true);
                Console.Beep(830, 100);
                contJ++;
            }
            if (k.Key == ConsoleKey.F12)
            {
                color_key2(0x30, true);
                Console.Beep(0x3a4, 100);
                contJ++;
            }
        }
        while (cont < 2);
    }

    public static void PianoEngineMarcha()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: | Marcha Nupcial                                                                                                                             | :|");
        Console.WriteLine("|: | Felix Mendelssohn                                                                                                                          | :|");
        Console.WriteLine("|: | (1842)                                                                                                                                     | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine(T1);
        Console.WriteLine(T2);
        Console.WriteLine(T3);
        Console.WriteLine(T4);
        Console.WriteLine(T5);
        Console.WriteLine(T6);
        Console.WriteLine(T7);
        Console.WriteLine(T8);
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                        Oprime Enter para tocar!!                                                           | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|: |                                                                                                                                            | :|");
        Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
        Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
        Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
        do
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            ConsoleKeyInfo info = Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: | Marcha Nupcial                                                                                                                             | :|");
            Console.WriteLine("|: | Felix Mendelssohn                                                                                                                          | :|");
            Console.WriteLine("|: | (1842)                                                                                                                                     | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T1);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T2);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T3);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T4);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T5);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T6);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T7);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine(T8);
            Console.SetCursorPosition(((Console.WindowWidth - T1.Length) / 2) - 1, Console.CursorTop);
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|: |                                                                                                                                            | :|");
            Console.WriteLine("|{>/--------------------------------------------------------------------------------------------------------------------------------------------/<}|");
            Console.WriteLine("| = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : = : =  = : |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------+");
            MarchaPlay();
            if (info.Key == ConsoleKey.Oem5)
            {
                color_key1(0, true);
                Console.Beep(0x105, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D1)
            {
                color_key3(0, true);
                Console.Beep(0x125, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D2)
            {
                color_key4(0, true);
                Console.Beep(0x149, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D3)
            {
                color_key1(12, true);
                Console.Beep(0x15d, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D4)
            {
                color_key3(12, true);
                Console.Beep(0x188, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D5)
            {
                color_key3(0x10, true);
                Console.Beep(440, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D6)
            {
                color_key4(0x10, true);
                Console.Beep(0x1ed, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D7)
            {
                color_key1(0x1c, true);
                Console.Beep(0x20b, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D8)
            {
                color_key3(0x1c, true);
                Console.Beep(0x24b, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D9)
            {
                color_key4(0x1c, true);
                Console.Beep(0x293, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.D0)
            {
                color_key1(40, true);
                Console.Beep(0x2ba, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.Oem4)
            {
                color_key3(40, true);
                Console.Beep(0x310, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.Oem6)
            {
                color_key3(0x2c, true);
                Console.Beep(880, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.Backspace)
            {
                color_key4(0x2c, true);
                Console.Beep(0x3da, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F1)
            {
                color_key2(0, true);
                Console.Beep(0x115, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F2)
            {
                color_key2(4, true);
                Console.Beep(0x137, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F4)
            {
                color_key2(12, true);
                Console.Beep(370, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F5)
            {
                color_key2(0x10, true);
                Console.Beep(0x19f, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F6)
            {
                color_key2(20, true);
                Console.Beep(0x1d2, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F8)
            {
                color_key2(0x1c, true);
                Console.Beep(0x22a, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F9)
            {
                color_key2(0x20, true);
                Console.Beep(0x26e, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F10)
            {
                color_key2(40, true);
                Console.Beep(740, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F11)
            {
                color_key2(0x2c, true);
                Console.Beep(830, 100);
                contJ++;
            }
            if (info.Key == ConsoleKey.F12)
            {
                color_key2(0x30, true);
                Console.Beep(0x3a4, 100);
                contJ++;
            }
        }
        while (cont < 2);
    }

    public static void QstnKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" _____ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|___  |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("  |  _|");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("  |_|  ");
        Console.SetCursorPosition(0x43, 0x21);
        Console.WriteLine("  |_|  ");
    }

    public static void SevenKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|_  |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("  | |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("  |_|");
    }

    public static void SixKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|  _|");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("| . |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|___|");
    }

    public static void Songs()
    {
        Console.SetCursorPosition(0x51, 8);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Marcha);
        Console.SetCursorPosition(0x51, 11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Cucaracha);
        Console.SetCursorPosition(0x51, 14);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(FurElise);
        Console.SetCursorPosition(0x51, 0x11);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Habanera);
        Console.SetCursorPosition(0x51, 20);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(America);
        Console.SetCursorPosition(0x51, 0x17);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(Freeplay);
    }

    public static void TenKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___   ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|_  | |   |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine(" _| |_| | |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|____||___|");
    }

    public static void ThreeKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|_  |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("|_  |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|___|");
    }

    public static void TwoKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|_  |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("|  _|");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|___|");
    }

    public static void ZeroKey()
    {
        Console.SetCursorPosition(0x43, 0x1d);
        Console.WriteLine(" ___ ");
        Console.SetCursorPosition(0x43, 30);
        Console.WriteLine("|   |");
        Console.SetCursorPosition(0x43, 0x1f);
        Console.WriteLine("| | |");
        Console.SetCursorPosition(0x43, 0x20);
        Console.WriteLine("|___|");
    }
}

 
Collapse Methods
 
