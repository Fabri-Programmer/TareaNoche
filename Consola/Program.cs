using Biblioteca;

Triangulo Valor12 = new Triangulo(); // instanciado el objeto 


int r;
string hola = "", hola1;
do
{
    Console.Write("Si o no =  ");
    hola1 = Console.ReadLine();
    if (hola1 == "si")
    {
        Console.Write("Ingrese nombre = ");
        hola = Console.ReadLine();
        if (hola == "Fabri")
        {
            Valor12.falo();
        }
        if (hola == "Magdiel")
        {
            Valor12.valor222();
        }
    }
    if (hola1 == "no")
    {
        Console.WriteLine("gracias");
        break;
        
    }
    
} while (hola == "si");

// segundo commit escondido
// a descansar tercer commmit
