namespace Silakov.Homework8
{
    public class Person
    {
        private int timeTiProcess;

        public int TimeToProcess 
        {
            get
            { 
                return timeTiProcess; 
            }
            set
            {
                if (value > 3000)
                {
                    throw new PersonException("Person with a lot of shopping is not served!");
                }
                else
                {
                    timeTiProcess = value;
                }
            }
        }
        public string Name { get; set; }
    }
}