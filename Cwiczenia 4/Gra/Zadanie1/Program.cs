using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zadanie1.classes;

public enum EHeroClass
{
    Barbarzynca,
    Paladyn,
    Amazonka
}

namespace Zadanie1
{
    class Program
    {
        static void HomeScreen()
        {
            Console.WriteLine("Witaj w grze LOTR");
            Console.WriteLine("[1] Zacznij nową grę");
            Console.WriteLine("[X] Zamknij program");

            String input;
            do
            {
                input = Console.ReadLine();
                if (input != "1" && input != "X")
                    Console.WriteLine("Wprowadziłeś niepoprawną wartość. Spróbuj ponownie!");
                else
                    break;
            } while (true);

            if (input == "1")
            {
                Console.Clear();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            HomeScreen();

            Hero hero = new Hero();

            hero.SetHeroName();
            Console.WriteLine("Witaj {0}!\n", hero.name);

            hero.ChooseHeroClass();

            hero.StartJourneyScreen();


            NonPlayerCharacter Bilbo = new NonPlayerCharacter("Bilbo", @"                       /\
        _/\           /  \
    _  /   \         /    \/\
   / \/   _ \     /\/\  _  _/\
  /   \_ / \/\_/\/_/  \/ \/   \
 /\/\   \_   /   \/            \
/    \___/\ /     \             \
           \       \             \
           .-'---.  \             \
__..---.. /       \  \             \
         /\___.-'./\''--..____..--''
`-.      \/ O) (O \/ ''--.._
    __    |  (_)  |         _.-'-._
   / /  __/\\___//\__ ..--''-._
   | (_/\ \/`---'\/ /\         `-._
_.-\ \/  \  \   /  /  \.-'-._
   /\|   /  -| |-  \   \     `-._
  | ||  /\  -| |-  /\   \        `-.
   \/|_/ |  -|_\-  |/   /
   \ \   /  /B_B\  \\  /
   / (   \_/  _  \_/ \/
.__\ \   /    |    \_/
   ) /''-| __ | __ |
   |(    \    |    /---...___
   /|    /____|____\         '-._
   ||     |   ||   |
   \\     ///\\//\\\
    \|   oOO(_)(_)OOo");
            NonPlayerCharacter Gandalf = new NonPlayerCharacter("Gandalf", @"                       ,---.
                       /    |
                      /     |
                     /      |
                    /       |
               ___,'        |
             <  -'          :
              `-.__..--'``-,_\_
                 |o/ ` :,.)_`>
                 :/ `     ||/)
                 (_.).__,-` |\
                 /( `.``   `| :
                 \'`-.)  `  ; ;
                 | `       /-<
                 |     `  /   `.
 ,-_-..____     /|  `    :__..-'\
/,'-.__\\  ``-./ :`      ;       \
`\ `\  `\\  \ :  (   `  /  ,   `. \
  \` \   \\   |  | `   :  :     .\ \
   \ `\_  ))  :  ;     |  |      ): :
  (`-.-'\ ||  |\ \   ` ;  ;       | |
   \-_   `;;._   ( `  /  /_       | |
    `-.-.// ,'`-._\__/_,'         ; |
       \:: :     /     `     ,   /  |
        || |    (        ,' /   /   |
        ||                ,'   /    |");
            NonPlayerCharacter[] NpcList = { Bilbo, Gandalf };
            Location riwendell = new Location("Riwendell", NpcList, true);

            // Zadanie 4 - dodawanie lokalizacji
            Location moria = new Location("Moria", null, false);
            Location minasTirith = new Location("Minas Tirith", null, true);
            Location isengard = new Location("Isengard", null, true);
            Location lothlorien = new Location("Lothlorien", null, false);
            Location shire = new Location("Shire", null, true);

            var locations = new List<Location>();
            locations.Add(riwendell);
            locations.Add(moria);
            locations.Add(minasTirith);
            locations.Add(isengard);
            locations.Add(lothlorien);
            locations.Add(shire);


            // Zadanie 4 - end



            // Dialog - Gandalf - Start
            NpcDialogPart npcDialogPart_Gandalf1 = new NpcDialogPart("Witaj {0}! Jak mogę Ci pomóc?");
            HeroDialogPart heroDialogPart_Gandalf1_1 = new HeroDialogPart("Poszukuję złota magu!");
            NpcDialogPart npcDialogPart_Gandalf1_1 = new NpcDialogPart("Złoto znajduje się w starej kopalni w podziemiach twierdzy Dol Guldur.");
            HeroDialogPart heroDialogPart_Gandalf1_1_1 = new HeroDialogPart("W takim razie zaprowadź mnie tam!");
            NpcDialogPart npcDialogPart_Gandalf1_1_1 = new NpcDialogPart("Jestem już za stary na taką wyprawę. Musisz poradzić sobie sam {0}!");
            HeroDialogPart heroDialogPart_Gandalf1_1_2 = new HeroDialogPart("Skąd posiadacie tak cenną wiedzę?");
            NpcDialogPart npcDialogPart_Gandalf1_1_2 = new NpcDialogPart("Hoho…. gdybym chciał Ci choć trochę opowiedzieć musielibyśmy siedzieć tutaj do końca świata i jeden dzień dłużej!");
            HeroDialogPart heroDialogPart_Gandalf1_2 = new HeroDialogPart("Wskaż mi drogę do wyjścia!");
            NpcDialogPart npcDialogPart_Gandalff1_2 = new NpcDialogPart("Nie jestem tutejszy. Przykro mi, nie pomogę Ci, radź sobie sam {0}!");

            Gandalf.Add_npc_first_dialog(npcDialogPart_Gandalf1);
            npcDialogPart_Gandalf1.AddHeroOption(heroDialogPart_Gandalf1_1);
            npcDialogPart_Gandalf1.AddHeroOption(heroDialogPart_Gandalf1_2);
            heroDialogPart_Gandalf1_1.AddNpcAnswer(npcDialogPart_Gandalf1_1);
            heroDialogPart_Gandalf1_2.AddNpcAnswer(npcDialogPart_Gandalff1_2);
            npcDialogPart_Gandalf1_1.AddHeroOption(heroDialogPart_Gandalf1_1_1);
            npcDialogPart_Gandalf1_1.AddHeroOption(heroDialogPart_Gandalf1_1_2);
            heroDialogPart_Gandalf1_1.AddNpcAnswer(npcDialogPart_Gandalf1_1);
            heroDialogPart_Gandalf1_2.AddNpcAnswer(npcDialogPart_Gandalff1_2);
            heroDialogPart_Gandalf1_1_1.AddNpcAnswer(npcDialogPart_Gandalf1_1_1);
            heroDialogPart_Gandalf1_1_2.AddNpcAnswer(npcDialogPart_Gandalf1_1_2);
            npcDialogPart_Gandalf1_1_2.AddHeroOption(heroDialogPart_Gandalf1_1_1);
            // Dialog - Gandalf - End

            // Dialog - Bilbo - Start
            NpcDialogPart npcDialogPartBilbo1 = new NpcDialogPart("Witaj wielkoludzie o imieniu {0}. Czego tutaj poszukujesz?");
            HeroDialogPart heroDialogPartBilbo1_1 = new HeroDialogPart("Chciałbym Cię bliżej poznać, słyszałem Twoją historię.");
            NpcDialogPart npcDialogPartBilbo1_1 = new NpcDialogPart("Stare dzieje… czego konkretnie chciałbyś się dowiedzieć o mnie?");
            HeroDialogPart heroDialogPartBilbo1_1_1 = new HeroDialogPart("Opowiedz mi o Pierścieniu!");
            NpcDialogPart npcDialogPartBilbo1_1_1 = new NpcDialogPart("Chodźmy więc w bardziej jasne miejsce. Tutaj jest zbyt mrocznie.");
            HeroDialogPart heroDialogPartBilbo1_1_2 = new HeroDialogPart("W jaki sposób udało Ci się przechytrzyć Smauga?");
            NpcDialogPart npcDialogPartBilbo1_1_2 = new NpcDialogPart("Smoki, tak samo jak i Hobbici posiadają swoje słabe punkty, które można wykorzystać.");
            HeroDialogPart heroDialogPartBilbo1_2 = new HeroDialogPart("Chciałbym zobaczyć się z Elrondem.");
            NpcDialogPart npcDialogPartBilbo1_2 = new NpcDialogPart("Obawiam się, że w tej chwili jest bardzo zajęty. Jednakże spróbuj znaleźć go w Wielkiej Sali.");

            Bilbo.Add_npc_first_dialog(npcDialogPartBilbo1);
            npcDialogPartBilbo1.AddHeroOption(heroDialogPartBilbo1_1);
            heroDialogPartBilbo1_1.AddNpcAnswer(npcDialogPartBilbo1_1);
            npcDialogPartBilbo1_1.AddHeroOption(heroDialogPartBilbo1_1_1);
            npcDialogPartBilbo1_1.AddHeroOption(heroDialogPartBilbo1_1_2);
            heroDialogPartBilbo1_1_1.AddNpcAnswer(npcDialogPartBilbo1_1_1);
            heroDialogPartBilbo1_1_2.AddNpcAnswer(npcDialogPartBilbo1_1_2);
            npcDialogPartBilbo1.AddHeroOption(heroDialogPartBilbo1_2);
            heroDialogPartBilbo1_2.AddNpcAnswer(npcDialogPartBilbo1_2);
            // Dialog - Bilbo - End



            hero.LocationScreen(riwendell, locations);


            Console.ReadKey();


        }
    }
}
