¿String es un tipo por valor o un tipo por referencia?
Es un tipo referencia
¿Qué secuencias de escape tiene el tipo string?

Nueva línea (\n): Representa un salto de línea.
Tabulación (\t): Representa un tabulador horizontal.
Comilla simple (\'): Representa una comilla simple.
Comilla doble (\"): Representa una comilla doble.
Barra invertida (\\): Representa una barra invertida.
Null (\0): Representa un carácter nulo.
etc.

¿Qué sucede cuando se utiliza una @ antes de una cadena de texto?
En C#, cuando se utiliza el símbolo "@" antes de una cadena de texto, se está definiendo una cadena literal textual, también conocida como verbatim string literal. Esto permite que la cadena ignore las secuencias de escape y trate los caracteres de manera literal, lo que es especialmente útil para incluir caracteres como las barras invertidas ("\") y para manejar cadenas que se extienden a través de múltiples líneas.

El símbolo "$" antes de una cadena de texto indica que se está utilizando una cadena interpolada. Las cadenas interpoladas permiten incrustar expresiones dentro de la cadena, y las expresiones se evalúan y se incluyen en la cadena resultante. Esta característica proporciona una manera concisa y legible de construir cadenas dinámicamente.
Las expresiones encerradas en "{}" dentro de una cadena interpolada se evaluarán y se convertirán en parte de la cadena resultante.