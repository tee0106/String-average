public class Kata
{
    public static void Main()
    {

    }

    public static string AverageString(string str)
    {
        string[] str_split = str.Split(' ');
        List<int> int_number = new List<int>();
        int average_num = -1;

        foreach (var str_number in str_split)
        {
            int_number.Add(ConvertStringToInt(str_number));
        }

        if (!int_number.Contains(-1))
        {
            average_num = (int)int_number.Average();
        }

        return ConvertIntToString(average_num);
    }

    private static int ConvertStringToInt(string str)
    {
        int number = -1;

        switch (str.ToLower())
        {
            case "zero": number = 0; break;
            case "one": number = 1; break;
            case "two": number = 2; break;
            case "three": number = 3; break;
            case "four": number = 4; break;
            case "five": number = 5; break;
            case "six": number = 6; break;
            case "seven": number = 7; break;
            case "eight": number = 8; break;
            case "nine": number = 9; break;
        }

        return number;
    }

    private static string ConvertIntToString(int number)
    {
        string str = "";

        switch (number)
        {
            case 0: str = "zero"; break;
            case 1: str = "one"; break;
            case 2: str = "two"; break;
            case 3: str = "three"; break;
            case 4: str = "four"; break;
            case 5: str = "five"; break;
            case 6: str = "six"; break;
            case 7: str = "seven"; break;
            case 8: str = "eight"; break;
            case 9: str = "nine"; break;
            default: str = "n/a"; break;
        }

        return str;
    }
}