# RESPUESTAS PREGUNTAS DEL TP
## ¿String es un tipo por valor o por referencia?
string es un tipo por referencia
## ¿Que secuencias de escape tiene el tipo string?
las secuencias de escape en un string nos permiten basicamente poder imprimir ciertos caracteres que no son sencillos de representar, los mismos siempre empiezan con \ seguidas de una letra o otros caracteres, en c# contamos con las siguientes
- SALTO DE LINEA: \n
- CAMPANA: \a
- RETROCESO: \b
- AVANCE DE PAGINA: \f
- RETORNO DE CARRO: \r
- TABULACION HORIZONTAL: \t
- TABULACION VERTICAL: \v
- COMILLA SIMPLE: \'
- COMILLA DOBLE: \"
- BARRA DIAGONAL INVERTIDA: \\\\
- SIGNO DE INTERROGACION LITERAL: \?
- CARACTER ASCII EN NOTACION OCTAL: \ooo
- CARACTER ASCII EN NOTACION HEXADECIMAL: \x hh
## ¿Que sucede cuando utiliza el caracter @ y $ antes de una cadena de texto?
### ¿Que sucede cuando utiliza el caracter @ antes de una cadena de texto?
cuando se utiliza el caracter @ antes de una cadena de texto, estamos especificando que queremos que la cadena se interprete y se muestre tal como la escribimos, es decir que las secuencias de escape como \n o \t se interpretaran y mostraran literalmente, a excepcion de una secuencia de escape "" que generara una comilla doble.
### ¿Que sucede cuando utiliza el caracter $ antes de una cadena de texto?
cuando se utiliza el caracter $ antes de una cadena de texto, estamos indicando que queremos obtener una cadena interpolada. la interpolacion de cadenas basicamente nos permite insertar variables dentro de una cadena, sin necesidad de hacer concatenaciones que pueden llegar a ser mas complicadas de lograr