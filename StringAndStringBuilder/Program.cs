using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any string");
        string s1 = Console.ReadLine();
        AppendString(s1);
        Console.WriteLine("String using string concat  function: " + s1);

        StringBuilder s2 = new StringBuilder("Welcome");
        AppendStringUsingStringBuilder(s2);
        Console.WriteLine("String using StringBuilder: " + s2);
    }
    public static void AppendStringUsingStringBuilder(StringBuilder str)
    {
        str.Append("Aarati");
    }
    public static void AppendString(string str)
    {
        string str2 = " Aarati";
        str=String.Concat(str,str2);
        //return s2;
    }
    
    
    
    
}
