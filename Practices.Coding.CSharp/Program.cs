// See https://aka.ms/new-console-template for more information
using Practices.Coding.CSharp;


bool check = true;
Console.WriteLine(check ? "Checked" : "Not Checked");
Console.WriteLine(false ? "Checked" : "Not Checked");
Days day = Days.Monday;
var daystring = day.GetDays();

Console.ReadLine();
PrintOutDateTime();

void PrintOutDateTime()
{
    DateTime localDate = DateTime.Now;
    var n = localDate.Month + 5;
    var culture = new System.Globalization.CultureInfo("en-US");

    //Line 1
    Console.WriteLine(localDate.ToString(culture));
    //Line 2
    Console.WriteLine(localDate.ToString("M/d/yyyy"));
    //Line 3
    Console.WriteLine(n);
}

Console.WriteLine("Hello, World!");

var version4 = new CSharpVersion4();
version4.LearnDynamicType();

