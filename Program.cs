namespace stringLibrary;

class Program
{
    static void Main(string[] args)
    {
        string st1="welcome to cSharp lesson",st2;

        Console.WriteLine(st1.Length);
        Console.WriteLine(st1.ToUpper());
        Console.WriteLine(st1.ToLower());
        st2=String.Concat("Hello, ",st1);

        Console.WriteLine(st2);
        
        Console.WriteLine(st1.CompareTo(st2));
        st2="Welcome to cSharp lesson";

    
        Console.WriteLine(string.Compare(st1,st2,true));
        Console.WriteLine(string.Compare(st1,st2,false));

        st2="cSharp";
        Console.WriteLine(st1.Contains(st2));

        Console.WriteLine(st1.EndsWith("hosgeldin"));
        Console.WriteLine(st1.StartsWith("welcome"));

        Console.WriteLine(st1.IndexOf("to"));
        Console.WriteLine(st1.IndexOf("k"));

        Console.WriteLine(st1.Insert(0,"hello"));

        Console.WriteLine(st1.LastIndexOf("s"));

        Console.WriteLine(st1+st2.PadLeft(30));
      
        Console.WriteLine(st1.Remove(10));

        Console.WriteLine(st1.Remove(2,10));

        Console.WriteLine(st1.Replace("cSharp","c#"));

        Console.WriteLine(st1.Split(" ")[1]);

        Console.WriteLine(st1.Substring(4,6));
    }
}
