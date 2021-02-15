using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage1._0
{
    public static class Extensions


    {//Prompt = det vi vill skriva ut på skärmen
        //Ui hanterar utskrift
        public static string AskForString(string prompt, IUI ui)
        {
            bool success = false;
            string answer;

            //loopa tills användaren har skrivit in något
            //Än så länge ingen annan validering
            do
            {
                Console.WriteLine(prompt);
                answer = ui.GetInput();

                if (String.IsNullOrWhiteSpace(answer))
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

        public static int AskForInt(string prompt, IUI ui)
        {
            bool success = false;
            int answer;

            do
            {
                string input = AskForString(prompt, ui);
                success = int.TryParse(input, out answer);  //Om vi kan parsa inputen till en int = true annars false
                if (!success)
                    ui.Print("Only numbers");


            } while (!success);

            return answer;

        }


        public static int FindIndex<T>(this T[] array, T item)
        {


            return Array.FindIndex(array, val => val.Equals(item));
        }
        public static void Hashcode(String value)
        {
            int result;

            // get hash code of the entered strings 
            result = value.GetHashCode();
            Console.WriteLine("String : {0} and HashCode: {1}", value, result);
        }


        public static bool EqualsInsensitive(this string str, string value)
        {
            return string.Equals(str, value, StringComparison.CurrentCultureIgnoreCase);
        }



        public static T[] RemoveAt<T>(this T[] arr, int index)
        {
            return arr.Where((e, i) => i != index).ToArray();
        }



       

    }
    public static class IEnumerableExt
    {
        public static T[] ToArrayOrNull<T>(this IEnumerable<T> seq)
        {
            var result = seq.ToArray();

            if (result.Length == 0)
                return null;

            return result;
        }
    }

}









