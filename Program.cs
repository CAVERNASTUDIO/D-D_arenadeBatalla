using System.IO;
using System;

int count=1, lanzamientos=1, caras=0,valor=0,level=0;
string idioma="";
string valorC="";
int[] a = new int[lanzamientos];
Random rand = new Random();
bool lanzamientoDados = true,suma=true;
string archivo = @$".\D&Drolllatter.erk";
File.AppendAllText(archivo, $"\n\nDungeons & Dragons\nCavern Studio\nCopyright (c) - 2026 Erik Alejandro García Aparicio\n============================================\n{DateTime.Now.ToString("gg yyyy/MM/dd - HH:mm")}\n============================================\n\nMovements: \nhour - countmovenments - Rolld# - #ofrolls - value \n");
interfaceIdioma();
inteface();


void interfaceIdioma(){
while(lanzamientoDados==true){

    lanzamientoDados=false;
    try{
    Console.Clear();
Console.WriteLine("Dungeons & Dragons ROLLS | Caverna Studio");
Console.WriteLine("============================================");
    Console.WriteLine("\nLanguage / Idioma:\n1. Español\n2. Ingles\n\n");
    idioma=Console.ReadLine();

    int idiomaNumerico = int.Parse(idioma);

    if (idiomaNumerico>2||idiomaNumerico<0){

        Console.WriteLine("Valor no valido, intenta nuevamente");
        Console.WriteLine("Value not found, try again.");
        Console.ReadLine();
        lanzamientoDados=true;
    }}
        catch
        {

        Console.WriteLine("Valor no valido, intenta nuevamente");
        Console.WriteLine("Value not found, try again.");
        Console.ReadLine();
        lanzamientoDados=true;
            
        }
    }
    

}

void documento()
{
string documento="";

if (caras!=2){
documento = $"{DateTime.Now.ToString("hh:mm:ss")} - {count++} - d{caras} - {lanzamientos} - {valor} \n";
}
else{
documento = $"{DateTime.Now.ToString("hh:mm:ss")} - {count++} - d{caras} - {lanzamientos} - {valorC} \n";
    }

File.AppendAllText(archivo,documento);
valor=0;
lanzamientos=0;
caras=0;
}

void numerodeLanzamientos()
{   
do{
try{
lanzamientoDados = false;   
Console.Clear();
Console.WriteLine("Dungeons & Dragons ROLLS");
Console.WriteLine("============================================");
if(idioma=="1"){Console.WriteLine("Ingrese el número de lanzamientos de dados que desea realizar: ");}
else{Console.WriteLine("Number of dice for rolls: ");}
string l = Console.ReadLine(); 
lanzamientos = Convert.ToInt32(l);

if (lanzamientos <= 0)
{
    if (idioma=="1"){Console.WriteLine("El número de lanzamientos debe ser mayor a cero. Intente nuevamente.");}
    else{Console.WriteLine("The number of rolls must be greater than zero, try again. ");}
    lanzamientoDados = true;
    Console.ReadLine();
}
else if (lanzamientos > level)
{
    if (idioma=="1"){Console.WriteLine($"El número de lanzamientos no puede ser mayor a {level}. Intente nuevamente.");}
    else{Console.WriteLine($"The number of rolls can not be more greater than {level}, try again.");}
    lanzamientoDados = true;
    Console.ReadLine();
}
}
catch
{
    if (idioma=="1"){Console.WriteLine("Debe ingresar un valor válido. Intente nuevamente.");}
    else{Console.WriteLine("No valid value, try again.");}
    lanzamientoDados = true;
    Console.ReadLine();
}

}while(lanzamientoDados == true);
}

void dado()
{
    
    do{
    do{
        try
        {
            lanzamientoDados = false;
            Console.Clear();
            Console.WriteLine("Dungeons & Dragons ROLLS"); 
            Console.WriteLine("============================================");
            
            if (idioma=="1"){Console.WriteLine("Ingresa el número de caras de el dado:");}
            else{Console.WriteLine("Number of heads of dice:");}
            string b =Console.ReadLine();
            caras = Convert.ToInt32(b);

            if (caras <= 2)
            {
                if (idioma=="1"){Console.WriteLine("El número de caras debe ser mayor a dos. Intente nuevamente.");}
                else{Console.WriteLine("The number of heads must be greater of two. Try Again.");}
                lanzamientoDados = true;
                Console.ReadLine();
            }
            else if (caras > 100)
            {
                if (idioma=="1"){Console.WriteLine("El número de caras no puede ser mayor a 100. Intente nuevamente.");}
                else {Console.WriteLine("The number of heads can not be more greater one honder. Try again.");}
                lanzamientoDados = true;
                Console.ReadLine();
            }
            
        }
        catch
        {
           if (idioma=="1"){ Console.WriteLine("Debe ingresar un número válido. Intente nuevamente.");}
           else{Console.WriteLine("Try again a valid value.");}
            lanzamientoDados = true;
            Console.ReadLine();
        }

    } while (lanzamientoDados == true);

    for (int i = 0; i < lanzamientos; i++)
    {
        a[i] = rand.Next(1, caras + 1);
        valor = valor + a[i];

        if (idioma=="1"){Console.WriteLine($"lanzamiento {i+1} d{caras} = {a[i]}");}
        else{Console.WriteLine($"Roll: {i+1} d{caras} = {a[i]}");}
    }
    
    if (suma== true){
    if (idioma=="1"){Console.WriteLine($"El valor total es: {valor}");}
    else{Console.WriteLine($"The total value is: {valor}");}
    Console.ReadLine();}
    else if (suma==false&&lanzamientos!=1)
    {

        if (idioma=="1"){Console.WriteLine("\n1. Mayor\n2. Menor\n\nOpcion:");}
        else{Console.WriteLine("\n1. Greater\n2. Lesser\n\nOption:");}
        string opcionT = Console.ReadLine();
        int b=0;

        if (opcionT == "1")
        {
            for(int i = 0; i<lanzamientos; i++)
                {

                    if (a[i] >= b)
                    {
                        valor=a[i];
                    }
                    else
                    {
                        valor = b;
                    }

                    b=a[i];
                }
        }
        else if (opcionT == "2")
        {
            for(int i = 0; i<lanzamientos; i++)
                {

                    if (a[i] >= b)
                    {
                        valor=b;
                    }
                    else
                    {
                        valor = a[i];
                    }

                    b=a[i];
                }
            
        }
        else
        {
           if (idioma=="1"){Console.WriteLine("Valor no valido, se repetira el lanzamiento");}
           else{Console.WriteLine("Not Valid value, roll repit");}
            Console.ReadLine();
            lanzamientoDados=true;
        }

        if (lanzamientoDados != true)
            {

                if (idioma=="1"){Console.WriteLine($"El valor seleccionado es: {valor}");}
                else{Console.WriteLine($"The select value is: {valor}");}
                Console.ReadLine();
                
            }
        }
        else{Console.ReadLine();}
    }while(lanzamientoDados==true);

}

void inteface() {
do{
lanzamientoDados = false;
Console.Clear();
Console.WriteLine("Dungeons & Dragons ROLLS");
Console.WriteLine("============================================");

if (idioma=="1"){Console.WriteLine("1. Lanzamiento\ne. Exit\n\nOpcion:");}
else{Console.WriteLine("1. Roll\ne. Exit\n\nOption:");}
string opcion = Console.ReadLine();

if (opcion=="1"){

do{   
lanzamientoDados = false;
Console.Clear();
Console.WriteLine("Dungeons & Dragons ROLLS");
Console.WriteLine("============================================");

if (idioma == "1"){Console.WriteLine("1. Suma\n2. Selección o unitario\n3. Moneda\n\nOpcion:");}
else{Console.WriteLine("1. Sum\n2. one roll or selection\n3. Coin\n\nOption:");}
string opcionD = Console.ReadLine();

if (opcionD == "1"){
level=30;
suma=true;
numerodeLanzamientos();
a = new int[lanzamientos];
dado();
documento();
}
else if (opcionD =="2"){
level=2;
suma=false;
numerodeLanzamientos();
a = new int[lanzamientos];
dado();
documento();
}
else if (opcionD == "3"){
caras=2;
a[0]=rand.Next(1,3);
if (idioma=="1"){
if (a[0]==1){valorC="cara";}
else {valorC="cruz";}}
else{
if (a[0]==1){valorC="heads";}
else {valorC="tails";}
}

if (idioma=="1"){Console.WriteLine($"El valor de la moneda lanzada es: {valorC}");}
else{Console.WriteLine($"The value of the roll coin is: {valorC}");}
Console.ReadLine();
documento();

                }
else{
    if (idioma=="1"){Console.WriteLine("Valor no valido, intenta nuevamente");}
    else{Console.WriteLine("No valid value, try again.");}
    Console.ReadLine();
    lanzamientoDados= true;}

    } while(lanzamientoDados!=false);
}
else if (opcion == "e")
    {
        lanzamientoDados = true;
        Console.WriteLine("\nCopyright (c) 2026, Erik Alejandro García Aparicio,all right reserved.\nOpen Game License v 1.0a Copyright 2000, Wizards of the Coast, LLC.\nSystem Reference Document 5.1 Copyright 2016, Wizards of the Coast, Inc.; Authors Mike Mearls, Jeremy Crawford, Chris Perkins, Rodney Thompson, Peter Lee, James Wyatt, Robert J. Schwalb, Bruce R. Cordell, Chris Sims, and Steve Townshend, based on original material by E. Gary Gygax and Dave Arneson.");
        Console.ReadLine();
    }
else
    {
        if (idioma=="1"){Console.WriteLine("Valor no valido ingresa un valor correcto");}
        else{Console.WriteLine("No valid value, try a correct value.");}
        Console.ReadLine();
    }
}while(lanzamientoDados == false);}

