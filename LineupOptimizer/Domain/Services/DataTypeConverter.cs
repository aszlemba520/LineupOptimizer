
namespace LineupOptimizer.Domain.Services
{
    public static class DataTypeConverter
    {
        public static bool StringToBool(string str)
        {
            if (str == "0")
                return false;
            return true;
        }

        public static int StringToInt(string str)
        {
            return int.Parse(str);
        }

    }
}
