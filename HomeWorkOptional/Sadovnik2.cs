namespace HomeWorkOptional
{
    public class Sadovnik2
    {
        public int[,] Pole2 { get; set; }
        public Sadovnik2(int[,] pole2)
        {
            Pole2 = pole2;
        }

        public void DoSadovnik2()
        {
            for (int i = Pole2.GetLength(1) - 1; i > 0; i--)
            {
                for (int b = Pole2.GetLength(0) - 1; b > 0; b--)
                {
                    if (Pole2[b, i] == 0)
                    {
                        Pole2[b, i] = 2;
                        Thread.Sleep(50);
                    }
                }
            }
        }
    }
}