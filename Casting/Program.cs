

class Entrada
{
    static void Main()
    {
        int entero = 10;
        float flotante = (float)entero;

        int otroEntero = 20;
        object objeto1 = otroEntero; // Boxing, de valor a referencia - Implicito

        int entero2 = (int)objeto1; // Unboxing, de referencia a valor. Es explicito.

        float flotante2 = (float)objeto1; // Unboxing - Error

        int valueType = 5;
        float flotante5 = (float)valueType; 

    }
}