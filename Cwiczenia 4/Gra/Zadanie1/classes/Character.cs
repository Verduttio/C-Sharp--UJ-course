using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.classes
{
    class Hero
    {
        public String name;
        public EHeroClass heroType;

        private String RemoveBlankChars(String name)
        {
            String name_no_blank_ch = "";
            //removing blank chars which are next to each other
            if (name.Length > 0)
            {
                if (name[0] != ' ')
                    name_no_blank_ch += name[0];
                for (int i = 1; i < name.Length; i++)
                {
                    if (name[i] == ' ')
                    {
                        if (name[i - 1] == name[i])
                        {
                            //remove
                        }
                        else
                        {
                            name_no_blank_ch += name[i];
                        }
                    }
                    else
                    {
                        name_no_blank_ch += name[i];
                    }
                }

                if (name.Last() == ' ')
                    name_no_blank_ch = name_no_blank_ch.Remove(name_no_blank_ch.Length - 1);

            }

            ///*testCode:*/ Console.WriteLine("Name: '{0}'", name_no_blank_ch);
            return name_no_blank_ch;
        }

        private bool ValidateHeroName()
        {
            name = RemoveBlankChars(name);

            //Rq: at least 2 non-blank heros
            if (name.Length < 2)
            {
                Console.WriteLine("DEBUG - {ValidateHeroName}: name.Length < 2");
                return false;
            }

            //Rq: alphabeth heros only and space ' '
            foreach (char c in name)
            {
                if (!((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || c == ' '))
                {
                    Console.WriteLine("DEBUG - {ValidateHeroName}: Non alphabeth hero encoutered");
                    return false;
                }
            }

            return true;
        }

        public void SetHeroName()
        {
            Console.Write("Podaj nazwę bohatera: ");

            name = Console.ReadLine();
            while (!ValidateHeroName())
            {
                Console.WriteLine("Nazwa bohatera nie spełnia polityki tworzenia nazw.\nSpróbuj jeszcze raz!");
                name = Console.ReadLine();
            }

            Console.Clear();
        }

        public void ChooseHeroClass()
        {
            Console.WriteLine("Wybierz swoją klasę: ");
            Console.WriteLine("[1] Barbarzynca\n[2] Paladyn\n[3] Amazonka");
            while (true)
            {
                String hero_class = Console.ReadLine();
                if (hero_class == "1")
                {
                    heroType = EHeroClass.Barbarzynca;
                    break;
                }
                else if (hero_class == "2")
                {
                    heroType = EHeroClass.Paladyn;
                    break;
                }
                else if (hero_class == "3")
                {
                    heroType = EHeroClass.Amazonka;
                    break;
                }
                else
                {
                    Console.WriteLine("Nie wybrałeś dostępnej klasy. Spróbuj ponownie!");
                }
            }
        }

        public void StartJourneyScreen()
        {
            Console.Clear();
            Console.WriteLine($"{this.heroType} {this.name} wyrusza na przygodę!!!\n");
            Console.WriteLine("Naciśnij dowolny klawisz by kontynuować.");
            Console.ReadKey();
        }

        public void ChooseLocationScreen(Location currentLocation, List<Location> locations)
        {
            Console.Clear();
            Console.WriteLine("Znajdujesz się w : {0}. Gdzie chcesz wyruszyć?\n", currentLocation.Name);

            var avaiableLocations = locations.Where(x => x.Name != currentLocation.Name && x.IsUnlocked == true)
                .OrderBy(x => x.Name);

            for(int i = 0; i < avaiableLocations.Count(); i++)
            {
                Console.WriteLine($"[{i}] {avaiableLocations.ElementAt(i).Name}");
            }


            Console.WriteLine("[X] Powrót");

            String option;
            int option_int = -1;
            do
            {
                option = Console.ReadLine();
                if (option == "X")
                    break;
                try
                {
                    option_int = int.Parse(option);
                    if (!(option_int >= 0 && option_int < avaiableLocations.Count()))
                        Console.WriteLine("Wprowadziłeś niepoprawną wartość. Spróbuj ponownie!");
                    else
                        break;

                }
                catch
                {
                    Console.WriteLine("Wprowadziłeś niepoprawną wartość. Spróbuj ponownie!");
                }
            } while (true);

            if (option == "X")
                LocationScreen(currentLocation, locations);
            else
            {
                LocationScreen(avaiableLocations.ElementAt(option_int), locations);
            }


        }

        public void LocationScreen(Location location, List<Location> locations)
        {
            Console.Clear();
            Console.WriteLine("Znajdujesz się w : {0}. Co chcesz zrobić?\n", location.Name);
            if (location.NpcList != null)
            {
                for (int i = 0; i < location.NpcList.Length; i++)
                {
                    Console.WriteLine("[{0}] Porozmawiaj z {1}", i, location.NpcList[i].Name);
                }
            }

            Console.WriteLine("[T] Podróżuj");
            Console.WriteLine("[X] Zamknij program");

            String option;
            int option_int = -1;
            do
            {
                option = Console.ReadLine();
                if (option == "X" || option == "T")
                    break;
                
                try
                {
                    option_int = int.Parse(option);
                    if (location.NpcList != null)
                    {
                        if (!(option_int >= 0 && option_int < location.NpcList.Length))
                            Console.WriteLine("Wprowadziłeś niepoprawną wartość. Spróbuj ponownie!");
                        else
                            break;
                    } else
                        Console.WriteLine("Wprowadziłeś niepoprawną wartość. Spróbuj ponownie!");
                }
                catch
                {
                    Console.WriteLine("Wprowadziłeś niepoprawną wartość. Spróbuj ponownie!");
                }
             
            } while (true);

            if (option == "X")
            {
                Environment.Exit(0);
            } else if (option == "T")
            {
                ChooseLocationScreen(location, locations);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Będziesz rozmawiał z {0}. Właśnie nadchodzi, przygotuj się...", location.NpcList[option_int].Name);
                Console.WriteLine(location.NpcList[option_int].AsciiPicture);
                Console.WriteLine("\nNacisnij dowolny klawisz gdy bedziesz gotów!");
                Console.ReadKey();
                TalkTo(location.NpcList[option_int]);
                LocationScreen(location, locations);
            }
        }

        public void TalkTo(NonPlayerCharacter npc)
        {
            NpcDialogPart npc_dialog = npc.StartTalking();
            DialogParser dialogParser = new DialogParser(this);
            List<HeroDialogPart> hero_options;
            while (npc_dialog != null)
            {
                Console.Clear();

                Console.WriteLine(dialogParser.ParseDialog(npc_dialog));
                Console.WriteLine("");
                hero_options = npc_dialog.getHeroOptions();


                if (hero_options.Count > 0)
                {
                    for (int i = 0; i < hero_options.Count; i++)
                    {
                        Console.WriteLine($"[{i}] {dialogParser.ParseDialog(hero_options[i])}");
                    }

                    String option;
                    int option_int = -1;
                    while (!(option_int >= 0 && option_int < hero_options.Count))
                    {
                        option = Console.ReadLine();
                        try
                        {
                            option_int = int.Parse(option);
                            if (!(option_int >= 0 && option_int < hero_options.Count))
                                Console.WriteLine("Wprowadziłeś niepoprawną wartość. Spróbuj ponownie!");
                        }
                        catch
                        {
                            Console.WriteLine("Wprowadziłeś niepoprawną wartość. Spróbuj ponownie!");
                        }
                    }
                    npc_dialog = hero_options[option_int].GetNpcAnswer();
                }
                else
                {
                    npc_dialog = null;
                }
            }
            Console.WriteLine("KONIEC. Nastąpi przekierowanie do ekranu lokalizacji. Naciśnij dowolny klawisz.");
            Console.ReadKey();
        }

    }

    class NonPlayerCharacter
    {
        String _name;
        String _asciiPicture;
        NpcDialogPart _firstDialog;

        public NonPlayerCharacter(String name, String asciiPicture)
        {
            this._name = name;
            this._asciiPicture = asciiPicture;
        }

        public void Add_npc_first_dialog(NpcDialogPart firstDialog)
        {
            this._firstDialog = firstDialog;
        }

        public String Name
        {
            get { return _name; }
        }

        public NpcDialogPart StartTalking()
        {
            return _firstDialog;
        }

        public String AsciiPicture
        {
            get { return _asciiPicture; }
        }
    }
}
