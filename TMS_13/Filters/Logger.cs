namespace TMS_13.Filters
{
    public static class Logger
    {
        public static void OnExecuting(string filter)
        {
            using (StreamWriter sw = new("Log.txt", true))
                sw.WriteLine($"This is {filter}Filter was executing at {DateTime.Now}:{DateTime.Now.Millisecond}");
        }
        public static void OnExecuted(string filter)
        {
            using (StreamWriter sw = new("Log.txt", true))
                sw.WriteLine($"This is {filter}Filter was executed at {DateTime.Now}:{DateTime.Now.Millisecond}");
        }
    }
}
