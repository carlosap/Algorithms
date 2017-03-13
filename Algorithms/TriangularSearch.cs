namespace LinearSearch
{
    public class Triangular
    {
        public int NumModels { get; set; }
        public int Possibilities { get; set; }
        public int Value { get; set; }
        public Triangular(int models, int max)
        {
            NumModels = models;
            Possibilities = max;
            Search();
        }

        private void Search()
        {
            Value = -1;
            var sum = 0;
            var counter = -1;
            if (NumModels > Possibilities)
            {
                return;
            }
                
            for (var x = 1; x < Possibilities; x++)
            {
                counter++;
                sum = sum + x;
                if (counter == (NumModels * 2))
                {
                    Value = sum;
                }              
            }
        }
    }
}
