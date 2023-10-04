using System.Reflection;
using System.Resources;

namespace ZapTranslation
{
    public class Translate
    {
        private static ResourceManager rm = new ResourceManager("ZapTranslation.Resources.Strings", Assembly.GetExecutingAssembly());

        public static string GetString(string text)
        {
            return rm.GetString(text);
        }
    }
}
