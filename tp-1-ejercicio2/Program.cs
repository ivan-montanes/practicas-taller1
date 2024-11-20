//booleano para controlar que la calculadora siga ejecutandose//
using System.ComponentModel;

bool calculadora = true;
//bucle para la calculadora//
while(calculadora){
    Console.WriteLine("----------CALCULADORA V2----------");
    Console.WriteLine("1: SUMAR");
    Console.WriteLine("2: RESTAR");
    Console.WriteLine("3: MULTIPLICAR");
    Console.WriteLine("4: DIVIDIR");
    Console.WriteLine("5: VALOR ABSOLUTO");
    Console.WriteLine("6: CUADRADO");
    Console.WriteLine("7: RAIZ CUADRADA");
    Console.WriteLine("8: SENO");
    Console.WriteLine("9: COSENO");
    Console.WriteLine("10: PARTE ENTERA");
    Console.WriteLine("11: SALIR");
    Console.WriteLine("eliga una operacion: ");
    string eleccionCadena = Console.ReadLine();
    int eleccion;
    bool resultado = int.TryParse(eleccionCadena, out eleccion);
    if( resultado && eleccion >= 1 && eleccion <= 10 ){
        //logica para operaciones de 2 valores//
        if( eleccion >= 1 && eleccion <= 4 ){
            //primer numero//
            bool resultadoConversionNumero1;
            double numero1 = 0;
            do{
                Console.WriteLine("ingrese un numero:");
                string numero1Cadena = Console.ReadLine();

                resultadoConversionNumero1 = double.TryParse(numero1Cadena,out numero1);
            }while( !resultadoConversionNumero1 );

            //segundo numero//
            bool resultadoConversionNumero2;
            double numero2 = 0;
            do{
                Console.WriteLine("ingrese un numero");
                string numero2Cadena = Console.ReadLine(); 
                resultadoConversionNumero2 = double.TryParse(numero2Cadena, out numero2);
            }while( !resultadoConversionNumero2 );


            //realizamos la operacion//
            double resultadoOperacion;
            switch( eleccion ){

                case 1: 
                    resultadoOperacion = numero1 + numero2;
                    Console.WriteLine("Resultado: "+resultadoOperacion);
                break;

                case 2: 
                    resultadoOperacion = numero1 - numero2;
                    Console.WriteLine("Resultado: "+resultadoOperacion);
                break;

                case 3:
                    resultadoOperacion = numero1 * numero2;
                    Console.WriteLine("Resultado: "+resultadoOperacion);
                break;

                case 4:
                    if(numero2 != 0){
                        resultadoOperacion = numero1 / numero2;
                        Console.WriteLine("Resultado: "+resultadoOperacion);
                    }else{
                        Console.WriteLine("no puede dividir por 0");
                    }
                break;

            }
        }else{
            //pedimos el numero para realizar la operacion//
            bool resultadoConversionNumeroUnico;
            double numero;
            do{
                Console.WriteLine("ingrese en numero:");
                string numeroUnicoCadena = Console.ReadLine();
                numero = 0;
                resultadoConversionNumeroUnico = double.TryParse(numeroUnicoCadena, out numero);
            }while( !resultadoConversionNumeroUnico );

            switch( eleccion ){

                case 5:
                    numero = Math.Abs(numero);
                    Console.WriteLine("VALOR ABSOLUTO "+numero);
                break;

                case 6:
                    numero = Math.Pow(numero,2);
                    Console.WriteLine("CUADRADO "+numero);
                break;

                case 7:
                    if(numero >= 0){
                        numero = Math.Sqrt(numero);
                        Console.WriteLine("Raiz Cuadrada: "+numero);
                    }else{
                        Console.WriteLine("No puede calcular la raiz cuadrada de un numero negativo");
                    }
                break;

                case 8:
                    numero = Math.Sin(numero);
                    Console.WriteLine("Seno: "+numero);
                break;

                case 9:
                    numero = Math.Cos(numero);
                    Console.WriteLine("Coseno: "+numero);
                break;

                case 10: 
                    numero = (int)numero;
                    Console.WriteLine("Parte Entera: "+numero);
                break;

            }
        }
    }else if( eleccion == 11 ){
        calculadora = false;
        Console.WriteLine("SALIENDO...");
    }else{
        Console.WriteLine("No se indico una opcion valida");
    }
}
