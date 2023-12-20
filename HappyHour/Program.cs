using System.Text.Json;

namespace HappyHour
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string header = "  _    _                           _    _                  \r\n | |  | |                         | |  | |                 \r\n | |__| | __ _ _ __  _ __  _   _  | |__| | ___  _   _ _ __ \r\n |  __  |/ _` | '_ \\| '_ \\| | | | |  __  |/ _ \\| | | | '__|\r\n | |  | | (_| | |_) | |_) | |_| | | |  | | (_) | |_| | |   \r\n |_|  |_|\\__,_| .__/| .__/ \\__, | |_|  |_|\\___/ \\__,_|_|   \r\n              | |   | |     __/ |                          \r\n              |_|   |_|    |___/    \n"
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(header);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press Enter to generate a cocktail!");
            Console.CursorVisible = false;

            while (true)
            {               
                ConsoleKeyInfo key = Console.ReadKey();

                if ( key.Key == ConsoleKey.Enter)
                {
                    using (HttpClient client = new HttpClient())
                    {

                        HttpResponseMessage response =
                            await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/random.php");

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();

                            DrinksWrapper drink = JsonSerializer.Deserialize<DrinksWrapper>(jsonResponse);

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            await Console.Out.WriteLineAsync(header);
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.SetCursorPosition(0, 10);

                            Console.ForegroundColor = ConsoleColor.Green;
                            await Console.Out.WriteLineAsync($"{drink.Drinks[0].StrDrink}\n");
                            Console.ForegroundColor = ConsoleColor.White;

                            foreach(var ingredient in drink.Drinks[0].Ingredients)
                            {
                                if(ingredient != null)
                                {
                                    await Console.Out.WriteLineAsync(ingredient);
                                }                               
                            }

                            await Console.Out.WriteLineAsync();

                            await Console.Out.WriteLineAsync($"{drink.Drinks[0].StrInstructions}\n");

                            await Console.Out.WriteLineAsync("Press Enter to generate a new cocktail");

                            Console.SetCursorPosition(0, 0);
                        }
                        else
                        {
                            await Console.Out.WriteLineAsync("Fail");
                        }

                    }
                }
                
            }
            
        }
    }
}
