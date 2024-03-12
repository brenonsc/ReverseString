namespace ReverseString.Util;

public class StringFormatter
{
    public static string InverterString(string str)
    {
        char[] charArray = str.ToCharArray();
        int inicio = 0;
        int fim = charArray.Length - 1;

        while (inicio < fim)
        {
            char temp = charArray[inicio];
            charArray[inicio] = charArray[fim];
            charArray[fim] = temp;
            
            inicio++;
            fim--;
        }

        return new string(charArray);
    }
}