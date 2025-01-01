public static void printMenu(string title, string[] menu) // prints a static menu
		{
			Console.Clear();
			if (menu.Length < 2)
			{
				Console.WriteLine("Invalid Menu Configuration for OVERLOAD");
			}
			else
			{
				for (int i = 0; i < (title.Length+4); i++)
				{
					Console.Write("="); // write the top bar
				}
				Console.Write("\n");
				Console.WriteLine("  " + title); // print menu title
				for (int i = 0; i < (title.Length+4); i++)
				{
					Console.Write("-"); // write the bottom bar
				}
				Console.Write("\n");
				for (int i = 1; i < menu.Count(); i++)
				{
					Console.Write(" " + i + ". "); // print the number for each option
					Console.WriteLine(menu[i]); // write the menu options each
				}
			}
		}

		public static string stringFirstLetterCaps(string toCap) // takes a string and returns the string with the first letter capitalized
		{
			string firstCharacterString = toCap.Substring(0, 1);
			string restOfString = toCap.Substring(1); // String.Substring() is overloaded so these are both valid
			firstCharacterString = firstCharacterString.ToUpper(); // the actual capitalization of the character
			string capped = firstCharacterString + restOfString; // reassembly of the string
			return capped;
		}
		public static void userAnyKey() // grabs input from user: anykey type
		{
			bool cc = true;
			do
			{
				Thread.Sleep(300);
				Console.Write("\n Press Any Key To Continue... ");
				ConsoleKeyInfo userEntry = Console.ReadKey();
				Console.Write("\n");
				cc = false;
			}
			while (cc);
		}
		public static string userInputString() // grabs input from user: string type
		{
			Thread.Sleep(300);
			Console.Write("\n~> ");
			string userString = Console.ReadLine();
			return userString;
		}
		public static char userInputChar() // grabs input from user: character type
		{
			Thread.Sleep(300);
			Console.Write("\n-> ");
			ConsoleKeyInfo userKey = Console.ReadKey();
			char userChar = userKey.KeyChar;
			return userChar;
		}
		public static int userInputInt() // grabs input from user: integer type
		{
			while (true)
			{
				Thread.Sleep(300);
				Console.Write("\n=> ");
				string userIntString = Console.ReadLine();
				if (! ((userIntString == null) || (userIntString == "")))
				{
					if (Int32.TryParse(userIntString, out int userInt))
					{
						return userInt;
					}
					else // error where the user entered a non-integer data type
					{
						Console.Write("\n Enter a whole integer in numerals. \n");
					}
				}
			}
		}
		public static double userInputDouble() // grabs input from user: double type
		{
			while (true)
			{
				Thread.Sleep(300);
				Console.Write("\n:> ");
				string userDoubleString = Console.ReadLine();
				if (! ((userDoubleString == null) || (userDoubleString == "")))
				{
					if (Double.TryParse(userDoubleString, out double userDouble))
					{
						return userDouble;
					}
					else // error where the user entered a non-double data type
					{
						Console.Write("Enter numerals with a decimal point.");
					}
				}
			}
		}
		public static bool userInputYesOrNo() // grabs input from user: boolean type
		{
			while (true)
			{
				Thread.Sleep(300);
				Console.Write(" Y/N: "); //ask the user for input
				ConsoleKeyInfo userEntry = Console.ReadKey(); //assign answer into a single-character variable
				Console.WriteLine(" ");
				if (! (userEntry.Key == ConsoleKey.Enter))
				{
					switch (userEntry.KeyChar)
					{
						case 'n': //check to see if the answer is a no
						{
							return false;
						}
						case 'N': // uppercase no
						{
							return false;
						}
						case 'y': //check to see if the answer is a yes
						{
							return true;
						}
						case 'Y': // uppercase yes
						{
							return true;
						}
						default: // corrects the user if they entered an incorrect key
						{
							Console.WriteLine("\n Use Y or N for yes or no respectively.");
							break;
						}
					}
				}
			}
		}