namespace Wetter_Pruefung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Der User soll dir mitteilen, ob das Wetter gerade "sonning" oder "regnerisch" ist.
            //Auch die Temperatur soll der User angeben können.
            //Liegt die Temperatur bei oder über 20°C und es ist sonning, empfehle dem User ein T-Shirt zu tragen.
            //Liegt die Temperatur unter 20°C und es ist sonnig, empfehle eine Jacke anzuziehen.
            //Bei regnerischen Wetter werden ebenfalls die zur Temperatur passenden Kleidungsempfehlungen ausgesprochen.
            //Zusätzlich soll der User darauf hingewiesen werden, dass er einen Tegenschirm mitnehmen soll.

            Console.WriteLine("Yo, bruh, sag bitte wie hoch die Temperatur bei dir ist. In Ziffern, nicht Buchstaben lol.");
            int temperatur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Und ist das Wetter gerade sonnig oder regnerisch?");
            string wetter = Console.ReadLine();
            wetter = wetter.ToLower();

            if (wetter == "sonnig" || wetter == "regnerisch")
            {
                Console.WriteLine("Nice. Also, meine Meinung nach...");
            }
            else
            {
                Console.WriteLine("Ich hab sonnig oder regnerisch gesagt, ist es so schwer? Oh Mann.. o.O");
            }

            if (wetter == "sonnig" && temperatur >= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du sollst ein T-Shirt tragen.;)");
            }
            else if (wetter == "sonnig" && temperatur < 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Eine Jacke wäre echt gut einzuziehen, Mann!:)");
            }
            else if (wetter == "regnerisch" && temperatur >= 20)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Das Wasser ist Nass, bro! Du sollst eine Regenmantel tragen!!");
            }
            else if (wetter == "regnerisch" && temperatur < 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Oh Em Gi! Du brauchst unbedingt eine Regenjacke einzuziehen! :o");
            }

            if (wetter == "regnerisch")
            {
                Console.WriteLine("BTW, als Hinweis: du sollst auch eine Regenschirm mitnehmen.\nAnsonsten kannst immer auch dein Head & Shoulders mitbringen und Zeit & Geld sparen. :D");
            }
        }
    }
}