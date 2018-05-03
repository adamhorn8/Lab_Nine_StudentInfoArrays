using System;
using System.Collections;

namespace LabNine_Student_Info_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Transfer lists from Lab Eight and add Favorite Color list
            int StudentNumber = 0;
            string[] NameL = { "Adam", "Bob", "Chris", "Dan", "Evan", "Frank", "George", "Hank", "Ivan", "Jim", "Kevin", "Lance", "Max", "Nick", "Oscar", "Peter", "Quinn", "Rick", "Sam", "Tommy" };
            string[] HometownL = { "Ancorage", "Budapest", "Cadiz", "Dubai", "Edinburgh", "Florence", "Geneva", "Hamburg", "Istanbul", "Jakarta", "Kyoto", "London", "Milan", "Naples", "Oslo", "Paris", "Quebec", "Reykjavík", "Seville", "Tangier" };
            string[] FavFoodL = { "Apple", "Beef", "Corn", "Donut", "Eggs", "Fish", "Gravy", "Ham", "Ice", "Jelly", "Kale", "Lemons", "Mushrooms", "Noodles", "Onion", "Pasta", "Quail", "Rice", "Steak", "Tomato" };
            string[] FavColorL = { "Aqua", "Blue", "Crimson", "Denim", "Emerald", "Forest Green", "Green", "Han Purple", "Ivory", "Jade", "Khaki", "Lilac", "Magenta", "Navy Blue", "Orange", "Pink", "Quartz Gray", "Red", "Scarlet", "Tan" };

            //Establsih ArrayLists for each of the lists above
            ArrayList Name = new ArrayList();
            ArrayList Hometown = new ArrayList();
            ArrayList FavFood = new ArrayList();
            ArrayList FavColor = new ArrayList();

            //Use a for loop to interate through each list, adding an item to the respective ArrayList until each item is added
            for (int i = 0; i < NameL.Length; i++)
            {
                Name.Add(NameL[i]);
            }
            for (int i = 0; i < HometownL.Length; i++)
            {
                Hometown.Add(HometownL[i]);
            }
            for (int i = 0; i < FavFoodL.Length; i++)
            {
                FavFood.Add(FavFoodL[i]);
            }
            for (int i = 0; i < FavColorL.Length; i++)
            {
                FavColor.Add(FavColorL[i]);
            }

            //Create while loop to validate student selection
            while (true)
            {
                Console.WriteLine("Would you like to add a student?");
                string AddStud = Console.ReadLine();
                if (AddStud == "yes" || AddStud == "y")
                {
                    Console.WriteLine("What is the name of the student?");
                    string NewStud = Console.ReadLine();
                    Name.Add(NewStud);
                    Console.WriteLine($"Where is {NewStud} from?");
                    string NewHomeTown = Console.ReadLine();
                    Name.Add(NewHomeTown);
                    Console.WriteLine($"What is {NewStud}'s favorite food?");
                    string NewFavFood = Console.ReadLine();
                    Name.Add(NewFavFood);
                    Console.WriteLine($"What is {NewStud}'s favorite color?");
                    string NewFavColor = Console.ReadLine();
                    Name.Add(NewFavColor);

                    AddStud = "no";
                }
                else if ((AddStud == "no" || AddStud == "n"))
                {
                    //Ask for user input
                    Console.WriteLine();
                    Console.Write("Which Student would you like to know about (1-20)? ");
                    string StudentNumberS = Console.ReadLine();



                    //Validate input using the tryparse method
                    bool StudentNumberB = int.TryParse(StudentNumberS, out StudentNumber);

                    StudentNumber = (StudentNumber - 1);


                    //If else statement to further validate input
                    if (StudentNumberB == true)
                    {
                        if ((StudentNumber >= 0 && StudentNumber <= Name.Count))
                        {
                            Console.WriteLine($"That student is {Name[StudentNumber]}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("That number was not between 1-20.  Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("That was not a number.  Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry do you want to add one?");
                }
            }

            //While loop to repeat information about student
            while (StudentNumber >= 0 && StudentNumber < Name.Count)
            {
                //Ask user what they would like to know
                Console.WriteLine();
                Console.WriteLine($"What would you like to know about {Name[StudentNumber]}?");
                Console.Write($"(Please type \"Hometown\", \"Favorite Food\", or \"Favorite Color\")");
                string MoreInfo = Console.ReadLine().ToLower();

                //If else to differentiate what user would like to learn
                if (MoreInfo == "hometown" || MoreInfo == "ht")
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Name[StudentNumber]}'s hometown is {Hometown[StudentNumber]}");

                    //Ask if user would like to know more
                    Console.WriteLine();
                    Console.WriteLine($"Would you like to know more about {Name[StudentNumber]}?");
                    Console.Write("Please enter \"Yes\" or \"No\" ");
                    string EvenMore = Console.ReadLine().ToLower();

                    //If else statement to determine whether or not they would like to know more
                    if (EvenMore == "no" || EvenMore == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks!");
                        break;
                    }
                    else if (EvenMore == "yes" || EvenMore == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didnt get that.");
                    }

                }//If else to differentiate what user would like to learn
                else if (MoreInfo == "favorite food" || MoreInfo == "ff")
                {
                    Console.WriteLine($"{Name[StudentNumber]}'s favorite food is {FavFood[StudentNumber]}");

                    //Ask if user would like to know more
                    Console.WriteLine();
                    Console.WriteLine($"Would you like to know more about {Name[StudentNumber]}?");
                    Console.Write("Please enter \"Yes\" or \"No\" ");
                    string EvenMore = Console.ReadLine().ToLower();

                    //If else statement to determine whether or not they would like to know more
                    if (EvenMore == "no" || EvenMore == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks!");
                        break;
                    }
                    else if (EvenMore == "yes" || EvenMore == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didnt get that.");
                    }
                }
                else if (MoreInfo == "favorite color" || MoreInfo == "fc")
                {
                    Console.WriteLine($"{FavColor[StudentNumber]}'s favorite color is {FavColor[StudentNumber]}");

                    //Ask if user would like to know more
                    Console.WriteLine();
                    Console.WriteLine($"Would you like to know more about {Name[StudentNumber]}?");
                    Console.Write("Please enter \"Yes\" or \"No\" ");
                    string EvenMore = Console.ReadLine().ToLower();

                    //If else statement to determine whether or not they would like to know more
                    if (EvenMore == "no" || EvenMore == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks!");
                        break;
                    }
                    else if (EvenMore == "yes" || EvenMore == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didnt get that.");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Hey sorry, I need you to type \"Hometown\", \"Favorite Food\", or \"Favorite Color\"");
                    Console.WriteLine("You can also type HT(hometown), FF(favorite food), FC(favorite color)");
                }
            }

        }
    }
}
