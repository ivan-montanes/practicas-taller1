//pedimos al usuario que ingrese un numero//
Console.WriteLine("ingrese un numero");
string numeroCadena = Console.ReadLine();
//invertimos la cadena//
//verificamos que la cadena pueda convertirse a numero en caso contrario mostramos un mensaje de error//
int numero;
bool resultadoConvertir = int.TryParse(numeroCadena,out numero);
if(resultadoConvertir){
    int cociente, resto, numeroInvertido = 0;
    do{
        cociente = numero / 10;
        resto = numero % 10;
        numero = cociente;
        numeroInvertido = (numeroInvertido * 10) + resto;
    }while(cociente != 0);
    Console.WriteLine("numero invertido: "+numeroInvertido);
}else{
    Console.WriteLine("no se ingreso una cadena en formato numerico");
}
