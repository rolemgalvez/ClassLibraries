using HomeworkTwentyLibrary.Models;

namespace HomeworkTwentyLibrary
{
    public static class Process
    {
        public static void Assign(PersonModel person)
        {
            person.FirstName = "Juan";
            person.LastName = "Cruz";
        }

        public static void Display(PersonModel person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }
}
