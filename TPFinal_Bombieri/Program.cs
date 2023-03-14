// Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
    // a. El mayor de los números pares.
    // b. La cantidad de números impares.
    // c. El menor de los números primos.
// Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

int n1, maxPar = 0, cantidadImpares = 0, menorPrimo = 0, banPar = 0, banMinPrimo = 0;

Console.WriteLine("Ingrese un número: ");
n1 = int.Parse(Console.ReadLine());

while (n1 != 0)
{    
    if(n1 % 2 == 0){
        if (banPar == 0){
            maxPar = n1;
            banPar = 1;
        }else if (n1 > maxPar)
            maxPar = n1;
    }else
        cantidadImpares++;

    if (primo(n1)){
        if (banMinPrimo == 0){
            menorPrimo = n1;
            banMinPrimo = 1;
        }else if (n1 < menorPrimo)
            menorPrimo = n1;             
    }

    Console.WriteLine("Ingrese un número: ");
    n1 = int.Parse(Console.ReadLine());
}

Console.WriteLine("El mayor de los números pares es: " + maxPar + ".");
Console.WriteLine("Los números impares ingresados fueron: " + cantidadImpares + ".");
Console.WriteLine("El menor número primo ingresado es: " + menorPrimo + ".");


static bool primo(int a){
    int con = 0;
    for (int x = 1; x <= a; x++){
        if (a % x == 0)
            con++;      
    }
    if (con == 2)
        return true;
    else
        return false;
}




