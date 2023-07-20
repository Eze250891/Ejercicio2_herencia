namespace Ejercicio2_herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cocaCola = new Refresco()
            {
                Nombre = "Coca Cola",
                Precio = 850,
                Sabor = "Cola",
                Marca = "CocaColaCompany"
            };

            var metodoGaseosa = cocaCola.GaseosaDestapada();


            Console.WriteLine($"El refresco {cocaCola.Nombre} tiene un costo de ${cocaCola.Precio}, es de sabor {cocaCola.Sabor}" +
                $" y pertenece a la empresa de {cocaCola.Marca}");
            Console.WriteLine(metodoGaseosa);

            var pielsen = new Cerveza()
            {
                Nombre = "Pielsen",
                Precio = 1500,
                Grado = 3,
                Amargor = 90,
            };

            var metodoCerveza = pielsen.EstaSerida();

            Console.WriteLine($"La cerveza {pielsen.Nombre} tiene un costo de ${pielsen.Precio}, tiene un amargor de {pielsen.Amargor} IBU" +
                $" y un grado de {pielsen.Grado}");
            Console.WriteLine(metodoCerveza);
        }
    }
}