namespace ClaseEstructura
{
    internal class Program
    {
        //Estructura cambio por tipo de valor sus valores iniciales no se modifican
        //Clase cambio por tipo de rerefencia sus valores iniciales se modifican
        static void Main(string[] args)
        {
            OperacionClase o1 = new OperacionClase(4,5);
            OperacionEstructura o2 = new OperacionEstructura(4, 5);
            //Valores que se tiene al inicio 
            Console.WriteLine("Valores iniciales de la clase operacion");
            Console.WriteLine(o1.ToString());
            Console.WriteLine("Valores iniciales de la estructura operacion");
            Console.WriteLine(o2.ToString());
            //Se llama al metodo incremento
            o1.incremento(o1, 10);
            o2.incremento(o2, 10);
            // Imprimimos valores finales ahora que se llamo al metod incremento
            Console.WriteLine("Valores Finales de la clase operacion");
            Console.WriteLine(o1.ToString());
            Console.WriteLine("Valores Finales de la estructura operacion");
            Console.WriteLine(o2.ToString());

        }
    }
}