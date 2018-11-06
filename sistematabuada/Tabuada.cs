using System;
namespace sistematabuada
{
    public class Tabuada
    {
        private int op;
        public void tabuadaCompleta(){
            Console.WriteLine("Informe uma operacao: \n1-Soma\n2-Subitracao\n3-Multiplicao\n4-Divisao");
            op = Int32.Parse(Console.ReadLine());

            Console.Clear();

            switch(op){
                case 1:
                    for (int i = 1; i <= 10;i++){
                        for (int o = 1; o <= 10; o++){
                            Console.WriteLine("{0}+{1} = {2}", i, o, (i + o));

                        }
                        Console.WriteLine("\n");
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int o = 1; o <= 10; o++)
                        {
                            Console.WriteLine("{0}+{1} = {2}", i, o, (i - o));
                        }

                        Console.WriteLine("\n");
                    }
                    break;

                case 3:
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int o = 1; o <= 10; o++)
                        {
                            Console.WriteLine("{0}+{1} = {2}", i, o, (i * o));
                        }

                        Console.WriteLine("\n");
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int o = 1; o <= 10; o++)
                        {
                            Console.WriteLine("{0}+{1} = {2}", i, o, (i / o));
                        }

                        Console.WriteLine("\n");
                    }
                    break;
                default:
                    Console.WriteLine("Operacao invalida");
                    break;

            }


        }
        public Tabuada()
        {
        }
    }
}
