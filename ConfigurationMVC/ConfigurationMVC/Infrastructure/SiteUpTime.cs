using System.Diagnostics;

namespace ConfigurationMVC.Infrastructure
{
    public class SiteUpTime
    {
        private readonly Stopwatch watch = new Stopwatch();

        public SiteUpTime()
        {
            watch.Start();
        }

        public long GetUpTime()
        {
            return watch.ElapsedMilliseconds;
        }
    }
}
