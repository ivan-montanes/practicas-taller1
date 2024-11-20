//booleano para controlar que la calculadora siga ejecutandose//
bool calculadora = true;
//bucle para la calculadora//
while(calculadora){
    Console.WriteLine("----------CALCULADORA V1----------");
    Console.WriteLine("1: SUMAR");
    Console.WriteLine("2: RESTAR");
    Console.WriteLine("3: MULTIPLICAR");
    Console.WriteLine("4: DIVIDIR");
    Console.WriteLine("5: SALIR");
    Console.WriteLine("eliga una operacion: ");
    string eleccionCadena = Console.ReadLine();
    int eleccion;
    bool resultado = int.TryParse(eleccionCadena, out eleccion);
    if( resultado && eleccion >= 1 && eleccion <= 4 ){
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
    }else if( eleccion == 5 ){
        calculadora = false;
        Console.WriteLine("SALIENDO...");
    }else{
        Console.WriteLine("No se indico una opcion valida");
    }
}

