using System;

namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            var person = new Person();

            DisplayMessages.Instants.ShowHello();

            person.Name = DisplayMessages.Instants.InputingName();
            person.Age = DisplayMessages.Instants.InputingAge();
            DisplayMessages.Instants.ShowMeetingWithUser(person.Name);

            var actions = new Actions();
            Console.WriteLine(actions.ChooseActions());
            actions.AllActions(person.Name,person.Age);
        }
    }
}
