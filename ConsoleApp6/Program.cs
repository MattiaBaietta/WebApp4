
namespace esercizio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menu tavolo1 = new Menu();
            
            do
            {
                Console.Clear();
                Menu.mostramenu();
                Console.WriteLine("Inserire l'operazione da eseguire");
                string opzione = Console.ReadLine();
                if (opzione==" ")
                {
                    Console.WriteLine("Chiusura del Programma in corso....");
                    Console.ReadLine();
                }
                else if (opzione=="11")
                {
                    tavolo1.stampaConto();
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                }
                else
                {
                    tavolo1.sceltapiatto(int.Parse(opzione));
                    Console.WriteLine("Premere un tasto per continuare");
                    Console.ReadLine();
                }
            }
            while (true);
        }

        public class Menu
        {
            private static string[] piatti = ["Coca Cola 150ml", "Insalata di pollo", "Pizza Margherita", "Pizza 4 Formaggi", "Pz patatine fritte", "Insalata di riso", "Frutta di stagione", "Pizza fritta", "Piadina vegetariana", "Panino hamburger"];
            private static double[] prezzi = [2.5, 5.2, 10, 12.5, 3.5, 8, 5, 5, 6, 7.9];
            private double contototale = 0;
            List<string> list = new List<string>();
            public static void mostramenu()
            {
                for (int i = 0; i < piatti.Length; i++)
                {
                    Console.WriteLine(i + 1 + ") " + piatti[i]+"  "+prezzi[i]+"€");
                }
                Console.WriteLine("11) Stampa conto finale e conferma");
            }
            public void sceltapiatto(int i)
            {
                Console.WriteLine("Hai ordinato: " + piatti[i-1]);
                list.Add(piatti[i-1]);
                contototale += prezzi[i-1];
            }
            public void stampaConto()
            {
                for (int i=0;i<list.Count;i++)
                {
                    Console.WriteLine(list[i] +"  "+ prezzi[i]+"€");

                }
                Console.WriteLine("La spesa totale è:" + (contototale+3));
            }
        }

    }
}