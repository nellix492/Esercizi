Rettangolo r = new Rettangolo();
Cerchio cerchio = new Cerchio();
string scelta;
double baseRettangolo;
double altezzaRettangolo;
double raggioCerchio;
do
{
    Console.WriteLine("\n----------- MENU-----------");
    Console.WriteLine("[A] Calcola area rettangolo");
    Console.WriteLine("[P] Calcola perimetro rettangolo");
    Console.WriteLine("[T] Calcola area triangolo");
    Console.WriteLine("[B] Calcola perimetro triangolo");
    Console.WriteLine("[E] Esci");
    Console.WriteLine("---------------------------------------------------------------\n");
    Console.Write("Scegli cosa vuoi fare?\n");
    scelta = Console.ReadLine().ToUpper();
    switch (scelta)
    {
        case "A":
            Console.WriteLine("\nInserisci la base del rettangolo : ");
            while (!double.TryParse(Console.ReadLine(), out baseRettangolo) && baseRettangolo <= 0)
            {
                Console.WriteLine("Inserisci un numero valido maggiore di zero per la base:");
            }
            Console.WriteLine("Inserisci l'altezza del rettangolo:");
            while (!double.TryParse(Console.ReadLine(), out altezzaRettangolo) || altezzaRettangolo <= 0)
            {
                Console.WriteLine("Inserisci un numero valido maggiore di zero per l'altezza:");
            }
            r.Base = baseRettangolo;
            r.Altezza = altezzaRettangolo;
            Console.WriteLine($"L'area del rettangolo è: {r.CalcolaArea()}");
            break;
        case "P":
            Console.WriteLine("\nInserisci la base del rettangolo : ");
            while (!double.TryParse(Console.ReadLine(), out baseRettangolo) && baseRettangolo <= 0)
            {
                Console.WriteLine("Inserisci un numero valido maggiore di zero per la base:");
            }
            Console.WriteLine("Inserisci l'altezza del rettangolo:");
            while (!double.TryParse(Console.ReadLine(), out altezzaRettangolo) || altezzaRettangolo <= 0)
            {
                Console.WriteLine("Inserisci un numero valido maggiore di zero per l'altezza:");
            }
            r.Base = baseRettangolo;
            r.Altezza = altezzaRettangolo;
            Console.WriteLine($"Il perimetro del rettangolo è: {r.CalcolaPerimetro()}");
            break;
        case "T":
            Console.WriteLine("\nInserisci il raggio del cerchio:");
            while (!double.TryParse(Console.ReadLine(), out raggioCerchio) && raggioCerchio <= 0)
            {
                Console.WriteLine("Inserisci un numero valido maggiore di zero per il raggio:");
            }
            cerchio.Raggio = raggioCerchio;
            Console.WriteLine($"L'area del cerchio è: {cerchio.CalcolaArea()}");
            break;

            break;
        case "B":
            Console.WriteLine("\nInserisci il raggio del cerchio:");
            while (!double.TryParse(Console.ReadLine(), out raggioCerchio) && raggioCerchio <= 0)
            {
                Console.WriteLine("Inserisci un numero valido maggiore di zero per il raggio:");
            }
            cerchio.Raggio = raggioCerchio;
            Console.WriteLine($"Il perimetro del cerchio è:\n {cerchio.CalcolaPerimetro()}");
            break;
        case "E":
            Console.WriteLine("Sei uscito dall'applicativo!!!");
            break;
        default:
            Console.WriteLine("\nScelta non valida. Riprova.");
            break;
    }
} while (scelta != "E");

public interface IFormaGeometrica
{
    double CalcolaArea();
    double CalcolaPerimetro();
}

public class Rettangolo : IFormaGeometrica
{
    public double Base { get; set; }
    public double Altezza { get; set; }
    public double CalcolaArea()
    {
        return Base * Altezza;

    }

    public double CalcolaPerimetro()
    {
        return (Base + Altezza) * 2;

    }
}

public class Cerchio : IFormaGeometrica
{
    public double Raggio { get; set; }

    public double CalcolaArea()
    {
        return Math.PI * Raggio * Raggio;
    }

    public double CalcolaPerimetro()
    {
        return 2 * Math.PI * Raggio;
    }
}
