using System;
using System.Linq;

namespace TryCatch
{

    public class DisplayMessages
    {
        private static DisplayMessages _instants;
        public static DisplayMessages Instants
        {
            get
            {
                if (_instants == null)
                {
                    _instants = new DisplayMessages();
                }
                return _instants;
            }
        }

        public void ShowMeetingWithUser(string name)
        {
            Console.Clear();
            Console.WriteLine($"{Constants.InputAndExeptionsConstants.Meeting}{name}");

        }

        public void ShowHello()
        {
            Console.WriteLine(Constants.InputAndExeptionsConstants.HelloConstant);
            Console.Write(Constants.InputAndExeptionsConstants.ClickToContinue);
            Console.ReadKey();
            Console.Clear();
        }

        public string InputingName()
        {
            var name = string.Empty;
            while (true)
            {
                Console.Write(Constants.InputAndExeptionsConstants.InputName);
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.Clear();
                    Console.WriteLine(Constants.InputAndExeptionsConstants.InputError);
                    continue;
                }
                if (name == "паша" || name == "Паша" || name == "павел" || name == "Павел")
                {
                    Console.WriteLine($"{ Constants.InputAndExeptionsConstants.PavelExeption}{name}");
                    continue;
                }

                if (!name.All(char.IsLetter))
                {
                    Console.Clear();
                    Console.WriteLine(Constants.InputAndExeptionsConstants.NameError);
                    continue;
                }

                Console.WriteLine();
                return name;
            }
        }

        public int InputingAge()
        {
            while (true)
            {
                Console.Write(Constants.InputAndExeptionsConstants.InputAge);
                var inputAge = Console.ReadLine();
                var isSucces = int.TryParse(inputAge, out var age);
                if (!isSucces)
                {
                    Console.Clear();
                    Console.WriteLine(Constants.InputAndExeptionsConstants.AgeError);
                    continue;
                }

                if (age < Constants.InputAndExeptionsConstants.MinPermissibleAge
                || age > Constants.InputAndExeptionsConstants.MaxPermissibleAge)
                {
                    Console.WriteLine(Constants.InputAndExeptionsConstants.AgeError);
                    continue;
                }
                return age;
            }
        }
    }
}
