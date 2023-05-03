

class Entrada
{
    static void Main()
    {
        //int i = null; -- Error
        //int? i = null; -- Question mark
        System.Nullable<int> i = null;

        System.Int32 c = 0;
        System.Int64 d = 0;



        var newVar = 10; // Se asigna el tipo de dato en tiempo de compilacion

        dynamic newVar2 = null; // Se le asigna el tipo de dato en tiempo de ejecucion


        bool boll = default(bool);

        int edad = 3;
        edad++;
        edad++;
        edad++;
        
        //checked
        //{
        //    edad++;
        //}

        double monto = double.MaxValue;

        var objPerson = new Persona() { Nombre = "Jerry" };

        CambiarNombre(objPerson);

        var objSalary = new Salary();
        objSalary = null;

        var doub1 = 102.33;
        var float1 = 122.33F;
        var decim3 = 545.3M;

        System.Double dec2 = 56.3;
    }

    static void CambiarNombre(Persona persona)
    {
        persona.Nombre = "Luis";
    }
}


class Persona
{
    public string Nombre { get; set; }
}

class Salary
{
    public int amount;

}