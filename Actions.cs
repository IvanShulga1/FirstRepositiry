using System;
using System.Collections.Generic;
namespace TryCatch
{
    class Actions
    {
        private string _actions;

        public string ChooseActions()
        {
            return Constants.InputAndExeptionsConstants.ChooseActions;
        }

        public void AllActions(string name, int age)
        {
            Console.Write(Constants.InputAndExeptionsConstants.FirstSign);
            Console.WriteLine(Constants.InputAndExeptionsConstants.FirstAction);

            Console.Write(Constants.InputAndExeptionsConstants.SecondSign);
            Console.WriteLine(Constants.InputAndExeptionsConstants.SecondAction);
            var person = new Person();


            while (true)
            {
                _actions = Console.ReadLine();
                if (_actions == Constants.InputAndExeptionsConstants.FirstSign)
                {
                    FirstActions(age);
                    break;
                }
                else if (_actions == Constants.InputAndExeptionsConstants.SecondSign)
                {
                    SecondActions(name);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(Constants.InputAndExeptionsConstants.Exeption);
                }
            }

        }

        private void FirstActions(int age)
        {
            var rnd = new Random();
            Console.WriteLine(Constants.InputAndExeptionsConstants.FirstActionResult + rnd.Next(age, 130));
        }

        private void SecondActions(string name)
        {
            var list = new List<string>();

            list.Add(Constants.SecondActionConditions.HighConditions);
            list.Add(Constants.SecondActionConditions.MurderConditions);
            list.Add(Constants.SecondActionConditions.WaterConditions);
            list.Add($"{Constants.SecondActionConditions.SaltConditions}{name}");
            list.Add(Constants.SecondActionConditions.SanyaMihailowConditions);


            var rnd = new Random();
            Console.WriteLine(list[rnd.Next(list.Count)]);
        }

    }
}


