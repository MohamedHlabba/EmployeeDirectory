using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
   public static class Util
    {
        public static string AskForString(string prompt ,ConsoleUI ui)
        {
            bool success = false;
            string answer;
            do
            {


                ui.Print(prompt);
                answer = ui.GetInput();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    ui.Print("You must enter something");

                }
                else
                {

                    success = true;

                }


            } while (!success);
            return answer;
        }

    public static int AskForInt(string prompt, ConsoleUI ui)

        {
            bool success = false;
            int answer;
            do
            {
                string input = AskForString(prompt, ui);
                success= int.TryParse(input, out answer);
                if(!success)
                {
                    ui.Print("Only Numbers");
                }


            } while (!success);

            return answer;
        }
    }


}
