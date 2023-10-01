namespace TucRunningSimulator2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Välkommen till Long Distance Runner-spelet!\r\nMata in din energinivå: MAX **50**");
            int energiNivå = int.Parse(Console.ReadLine());
            int antalKm = 10;

            if (energiNivå > 50)
            {
                Console.WriteLine("***Du har valt för HÖG Energi!***");
                Environment.Exit(0);
            }

            while (antalKm >= 1 && energiNivå >= 1)
            {

                Console.WriteLine("Din energinivå är: " + energiNivå + " och du har " + antalKm + " Km kvar");
                Console.WriteLine("Ange hastigheten du vill använda varje hastighet täcker 1km avstånd : snabbast , snabb , måttlig , långsam eller promenad");
                string distans = Console.ReadLine();

                int snabbast = -15;
                int snabb = -10;
                int måttlig = -8;
                int långsam = -5;
                int promenad = -2;



                switch (distans)
                {
                    case "snabbast":

                        energiNivå = energiNivå + snabbast;
                        antalKm = antalKm - 2;

                        Console.WriteLine("Du har valt **Snabbast** och har kvar " + energiNivå + " energi." + " Avstånd täckt: " + antalKm + " km");
                        break;
                    case "snabb":

                        energiNivå = energiNivå + snabb;
                        antalKm = antalKm - 1;

                        Console.WriteLine("Du har valt **Snabb** och har kvar " + energiNivå + " energi" + " Avstånd täckt: " + antalKm + "km");
                        break;
                    case "måttlig":

                        energiNivå = energiNivå + måttlig;
                        antalKm = antalKm - 1;

                        Console.WriteLine("Du har valt **Måttlig** och har kvar " + energiNivå + " energi" + " Avstånd täckt: " + antalKm + "km");
                        break;
                    case "långsam":

                        energiNivå = energiNivå + långsam;
                        antalKm = antalKm - 1;

                        Console.WriteLine("Du har valt **Långsam** och har kvar " + energiNivå + " energi" + " Avstånd täckt: " + antalKm + "km");
                        break;
                    case "promenad":

                        energiNivå = energiNivå + promenad;
                        antalKm = antalKm - 1;

                        Console.WriteLine("Du har valt **Promeand** och har kvar " + energiNivå + " energi" + " Avstånd täckt: " + antalKm + "km");
                        break;
                }
            }
            if (energiNivå <= 1)
            {
                Console.WriteLine("***DU HAR INGEN ENERGI KVAR!*** \n Du täckte " + antalKm + " km");
            }
            else
            {
                Console.WriteLine("***Grattis du nådde målet! 10km, Guld-medalj till DAJ!!!***");

            }
        }


    }
}   

