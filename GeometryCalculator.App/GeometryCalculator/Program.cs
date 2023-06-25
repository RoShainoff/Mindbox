using GeometryLibrary;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Введите наименование типа в формате namespace.typeName: ");
        var typeName = Console.ReadLine();
        var type = Type.GetType(typeName + $", {nameof(GeometryLibrary)}");
        if (type != null)
        {
            var figure = (Figure)Activator.CreateInstance(type);

            if (figure != null)
            {
                Console.WriteLine(figure.ToString());
            }
        }
        else
        {
            Console.WriteLine("Неверный тип");
        }

        Console.ReadKey();
    }
}