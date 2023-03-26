using System;

namespace Testy_Sejfu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] pokretla = { 0, 0, 0 };
            char key;
            for(int i = 0; i<pokretla.Length; i++)
            {
                pokretla[i] = rnd.Next(0, 30);
            }
            foreach(int i in pokretla)
            {
                Console.WriteLine(i);
            }

            while (true)
            {
                key = (char)Console.Read();
                if (key == 'e')
                    pokretla = Rotate(1, pokretla);
                else if (key == 'q')
                    pokretla = Rotate(-1, pokretla);
                foreach (int i in pokretla)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int[] Rotate(int direction, int[] pokretla)
        {
            if(direction == 1)
            {
                if(check(pokretla[0]))
                {
                    if(check(pokretla[1], 0))
                    {
                        pokretla[0] = 0;
                        pokretla[1] = 1;
                        if(check(pokretla[2], 1))
                        {
                            pokretla[2] = 2;
                        }
                    }
                    else
                    {
                        pokretla[0] = 0;
                    }
                }
                else
                {
                    if(check(pokretla[1], pokretla[0]+1))
                    {
                        pokretla[0]++;
                        if(check(pokretla[1]))
                        {
                            pokretla[1] = 0;
                            if (check(pokretla[2], 0))
                                pokretla[2] = 1;
                        }
                        else
                        {
                            pokretla[1]++;
                            if (check(pokretla[2], pokretla[1]))
                            {
                                if (check(pokretla[2]))
                                    pokretla[2] = 0;
                                else
                                    pokretla[2]++;
                            }
                        }
                        
                    }
                    else
                    {
                        pokretla[0]++;
                    }
                }
            }
            else if(direction == -1)
            {
                if (check(pokretla[0], 0))
                {
                    if (check(pokretla[1], 29))
                    {
                        pokretla[0] = 29;
                        pokretla[1] = 28;
                        if (check(pokretla[2], 28))
                        {
                            pokretla[2] = 27;
                        }
                    }
                    else
                    {
                        pokretla[0] = 29;
                    }
                }
                else
                {
                    if (check(pokretla[1], pokretla[0] - 1))
                    {
                        pokretla[0]--;
                        if (check(pokretla[1], 0))
                        {
                            pokretla[1] = 29;
                            if (check(pokretla[2], 29))
                                pokretla[2] = 28;
                        }
                        else
                        {
                            pokretla[1]--;
                            if (check(pokretla[2], pokretla[1]))
                            {
                                if (check(pokretla[2], 0))
                                    pokretla[2] = 29;
                                else
                                    pokretla[2]--;
                            }
                        }

                    }
                    else
                    {
                        pokretla[0]--;
                    }
                }
            }


            return pokretla;
        }

        static bool check(int pokretlo, int check = 29)
        {
            if(pokretlo==check)
            {
                return true;
            }
            return false;
        }
    }
}
