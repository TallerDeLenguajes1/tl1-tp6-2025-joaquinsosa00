// See https://aka.ms/new-console-template for more information

//-------------------------------------- Punto 1 --------------------------------------




//Console.WriteLine("Ingrese un numero:");

/*string entrada=Console.ReadLine();    //Otra opcion
numero=int.Parse(entrada); */
/*


int numero2=int.Parse(Console.ReadLine());

while(numero2>0){
Console.Write(numero2%10);
numero2=numero2/10;
}

*/


//-------------------------------------- Punto 2 --------------------------------------

int opcion=0;
do
{

Console.WriteLine("-------------CALCULADORA-------------:");
Console.WriteLine("Ingrese una opcion:");
Console.WriteLine("1: Sumar");
Console.WriteLine("2: Restar");
Console.WriteLine("3: Multiplicar");
Console.WriteLine("4: Dividir");
Console.WriteLine("5: Salir");


opcion=int.Parse(Console.ReadLine());

if(opcion<0 || opcion>5){
    
Console.WriteLine("Opcion no valida");

}
else{
Console.WriteLine("Ingrese el primer valor");
int valor1=int.Parse(Console.ReadLine());
Console.WriteLine("\nIngrese el segundo valor");
int valor2=int.Parse(Console.ReadLine());

int resultado=0;
switch (opcion)
{
    case 1:
        resultado=valor1+valor2;
        Console.WriteLine("\n\n"+valor1+"+"+valor2+"="+resultado);
    break;
    case 2:
        resultado=valor1-valor2;
        Console.WriteLine("\n\n"+valor1+"-"+valor2+"="+resultado);
    break;
    case 3:
        resultado=valor1*valor2;
        Console.WriteLine("\n"+valor1+"*"+valor2+"="+resultado);
    break;
    case 4:
        resultado=valor1/valor2;
        Console.WriteLine("\n"+valor1+"/"+valor2+"="+resultado);
    break;
    case 5:
        break;
    
    
}
Console.WriteLine("\n Desea realizar otro calculo?");
Console.WriteLine("1:Si");
Console.WriteLine("2:No");
int continuar=int.Parse(Console.ReadLine());
if (continuar==2){
    Console.WriteLine("\nSaliendo");
    opcion=5;
}
}
} while (opcion!=5);






