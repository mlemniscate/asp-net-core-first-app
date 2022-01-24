namespace Section2DesignPatterns.Infrastructure
{
    public class ViewCounter
    {
        private static ViewCounter viewCounter;
        private ViewCounter()
        {

        }
        public static ViewCounter GetInstance()
        {
            if(viewCounter == null)
                viewCounter = new ViewCounter();
            return viewCounter;
        }
        public int Count { get; set; } = 0;

        public void AddCount()
        {
            Count++;
        }
    }
}
