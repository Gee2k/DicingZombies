using System;
using System.Collections.Generic;

namespace Play
{
    public class ZombieNameGenerator
    {
        private static List<string> nameAdjectives = new List<string> { "Decayed", "Six-year old", "Healthiest", "Magically animated", "Freshly dead", "Sullen little", "Out-of-sight", "Completely human", "Overzealous", "Big, hulking", "Painfully slow", "Really old", "Dreadful", "Pickled", "Mindless", "Unguided", "Blank-faced", "Headless", "Horrendous", "Wide-shouldered", "Skeletal", "Month-old", "Haitian", "Cross-eyed", "Still fresh", "Stumpy", "Bloodless", "Withered old", "Hardcore", "Flaming", "Slimy", "Obese", "Deranged", "Computerized", "Interim", "Tattered", "Murderous", "Good old", "Troublesome", "Soulless", "Underwater", "Open-mouthed", "Big Blue", "Squashed", "Restless", "Stray", "Self-sufficient", "Gruesome", "Psychotic", "Striking", "Average", "Hairless", "Eerie", "Ruthless", "Ragged", "Stiff", "Monstrous", "Crazed", "Reluctant", "Paranoid", "Mutant", "Unrelenting", "Leftover", "Scary", "Shredded", "Damned", "Hungry", "Lethal", "Huge", "Mangled", "Decrepit", "Dangerous", "Bloated", "Lumbering", "Hulking", "Uniformed", "Ill", "Mad", "Bloody", "Towering", "Powerful", "Violent", "Grotesque", "Rotten", "Slow" };
        private static List<string> firstNames = new List<string> { "Sarah", "Molly", "Hannah", "Isabella", "Amber", "Alice", "Martha", "Marya", "Abigail", "Megan", "Amelia", "Sophie", "Mia", "Amy", "Ela", "Isabelle", "Eleanor", "Chloe", "Emily", "Millie", "Jasmine", "Elizabeth", "Ellie", "Holly", "Poppy", "Jessica", "Florence", "Freya", "Phoebe", "Nicole", "Rebecca", "Emma", "Renee", "Francine", "Crimson", "Dianne", "Eyeball", "Selena", "Samantha", "Ana", "Henry", "Michael", "Christopher", "Daniel", "Jacob", "Adam", "John ", "William", "Jake", "Nathan", "Richard", "Samuel", "Ethan", "Robert", "Harrison", "Aaron", "Benjamin", "Oliver", "Jack", "Dewey", "Louis", "Thomas", "Charles", "Matthew", "Harry", "Joshua", "Edward", "James", "David", "Luke", "Joseph", "Kenneth", "Ben", "Travis", "Wayne", "Renee", "Trevor", "Kyle ", "Max", "Riley", "Lynna", "Jim", "Burt", "Neil", "Dan" };

        public string getRandomZombieName()
        {
            Random random = new Random();
            string randomAdjective = nameAdjectives[random.Next(nameAdjectives.Count)];
            string randomFirstName = firstNames[random.Next(firstNames.Count)];
            string zombieName = randomAdjective + " " + randomFirstName;
            return zombieName;
        }
    }
}