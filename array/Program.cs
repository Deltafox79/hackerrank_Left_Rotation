using System;

namespace array
{
    class Program
    {
        //Left Rotation Problems - Solution By DeltaFoX aka Russo Paolo Rito 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string array divided by space example (1 2 3 4 5) :\n");
            string[] nd = Console.ReadLine().Trim().Split(' ');
            //Se Input è minore o Uguale a 1 Esco dal Soft
            if (nd.Length <= 1)
                Environment.Exit(0);
            Console.WriteLine("\nEnter the desired number of left rotation :\n");
            try
            {
                //Converto in int la stringa  del numero desiderato per la rotazione a sx
                int nl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPartial Result :\n");
                //Ottengo la lunghezza dell'array stringa in input
                int l = nd.Length;
                //Printo a Video su singola linea i primi valori dell'array inseriti
                Console.Write("[" + string.Join(" ", nd) + "] ");
                //ciclo for su array in input per gestire tutti gli nl valori di rotazione richiesti
                for (int d = 0; d < nl; d++)
                {
                    //Salvo il primo valore dell'array per posizionarlo dopo in coda
                    string start = nd[0];
                    //Nuovo Ciclo for per la rotazione a sx dei rimanenti valori 1 >
                    for (int i = 1; i < l; i++)
                        nd[i - 1] = nd[i];
                    //posiziono il primo valore in coda
                    nd[l - 1] = start;
                    // Printo a video la stringa ottenuta dal "calcolo"
                    Console.Write(" - [" + string.Join(" ", nd) + "] ");
                }
                Console.WriteLine("\n\nFinal Result :\n");
                //Printo il valore finale richiesto anche a parte
                Console.WriteLine(string.Join(" ", nd));
            }
            catch
            {
                //In caso di eccezioni Comunico Errore
                Console.WriteLine("Error in execution !.");
            }
            //Attendo Input da parte Utente per chiudere la win della Console
            Console.ReadLine();
        }
    }
}
