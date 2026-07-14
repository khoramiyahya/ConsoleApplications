
namespace ConsoleApplications
{
    public static class IdGenerator
    {
        private static int LastId = 1;
        public static int GetId()
        { return LastId++; }
    }
}
