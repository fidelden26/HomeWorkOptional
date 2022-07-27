namespace HomeWorkOptional
{
    public class Sadovnik1
    {
        public int[,] Pole { get; set; }
        public Sadovnik1(int[,] pole)
        {
            Pole = pole;
        }
        public void DoSadovnik()
        {
            for (int i = 0; i < Pole.GetLength(0); i++)
            {
                for (int a = 0; a < Pole.GetLength(1); a++)
                {
                    if (Pole[i, a] == 0)
                    {
                        Pole[i, a] = 1;
                        Thread.Sleep(50);
                    }

                }
            }
        }
    }
}