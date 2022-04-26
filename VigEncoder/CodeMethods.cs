namespace VigEncoder
{
    public abstract class CodeMethods
    {
        public static string Alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static char IntToString(int number)
        {
            char line = Alf[number - 1];
            return line;
        }
        public static int StringToInt(char line)
        {
            int numString = Alf.IndexOf(line) + 1;
            return numString;
        }
        public static int EnRotate (char text, char key)
        {
            int index;
            index = (StringToInt(text) + StringToInt(key) - 1) % 33;
            if (index == 0)
            {
                index = 33;
            }
            return index;
        }
        public static int DeRotate(char text, char key)
        {
            int index;
            index = (StringToInt(text) - StringToInt(key) +67) % 33;
            if (index == 0)
            {
                index = 33;
            }
            return index;
        }
    }
}