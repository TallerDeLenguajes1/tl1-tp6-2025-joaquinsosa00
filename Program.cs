// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;


int c;

Console.WriteLine("Ingrese un numero:");
string entrada=Console.ReadLine();
c=int.Parse(entrada); 

while(c>0){


Console.Write(c%10);
c=c/10;
}
