namespace BilgeAdam.Restaurant.Common.Helper
{
    static class EnumerateManager
    {
        private static int index;
        public static int Generate()
        {
            return ++index;
        }
    }
}
