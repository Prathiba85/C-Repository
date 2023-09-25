using System;
//
String[] a = { "Hello", "bye", "Rahul", "Shetty" };
int[] b = { 3, 4, 5, 6 };
String[] a1 = new String[4];
a1[0] = "hello";
a1[1] = "bye";
//Console.WriteLine(a1[0]);

for (int i =0; i<a.Length; i++)
{
    //Console.WriteLine(a1[i])
    Console.WriteLine(a[i]);

    if (a[i].Equals("Rahul"))
        {

        Console.WriteLine("Match found");
    }
}