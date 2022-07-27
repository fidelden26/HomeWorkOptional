namespace HomeWorkOptional
{

    internal class Program
    {
        static async Task DoSadovnikAsync(Sadovnik1 sadovnik1)
        {
            await Task.Run(() => sadovnik1.DoSadovnik());
        }

        static async Task DoSadovnikAsync2(Sadovnik2 sadovnik2)
        {
            await Task.Run(() => sadovnik2.DoSadovnik2());
        }

        static async Task Main(string[] args)
        {
            int[,] Sad = new int[5, 5];
            Sadovnik1 sadovnik1 = new Sadovnik1(Sad);
            Sadovnik2 sadovnik2 = new Sadovnik2(Sad);

            DoSadovnikAsync(sadovnik1);
            await DoSadovnikAsync2(sadovnik2);            

            for (int i = 0; i < Sad.GetLength(0); i++)
            {
                for (int j = 0; j < Sad.GetLength(1); j++)
                {
                    Console.Write($"{Sad[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}