namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.

        Console.WriteLine("Ce programe peut converti une température soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius !");
        Console.WriteLine("\nSi vous voulez converti de degrés Celsius vers Fahrenheit (tapez C)\nSi vous voulez converti de degrés Fahrenheit vers Celsius (tapez F)");
        string unité = Console.ReadLine();
        while(unité is not "c" and not "C" and not "f" and not "F")
        {
            Console.WriteLine("\nJe n'ai pas compris votre choix.\nVeillez taper  'C' ou 'F'");
            unité = Console.ReadLine();
        }
        Console.WriteLine("\nMaintenant entrez une température !");
        int température = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        if (unité is "c" or "C")
        {
            Console.WriteLine(température + "°C --> " + (température + 32) + "°F");
        }
        else if(unité is "f" or "F")
        {
            Console.WriteLine(température + "°F --> " + (température - 32) + "°C");
        }
        else
        {
            Console.WriteLine("\n\n\n\nerror\n\n\n\n");
        }
        Console.WriteLine("");
    }
}