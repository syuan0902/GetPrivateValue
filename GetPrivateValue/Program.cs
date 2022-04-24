using System;
using System.Reflection;

namespace GetPrivateValue
{
    class Program
    {
        static void Main(string[] args)
        {
            HasASecret keeper = new HasASecret();

            //Console.WriteLine(keeper.secret);

            //用reflection取得secret欄位的值
            FieldInfo[] fields = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.GetValue(keeper));
            }
        }
    }
}
