using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
	partial class Practice
	{
		//B4-P1/25. If_TimeOfDayGreeting
		public static void B4_P1_25_If_TimeOfDayGreeting()
		{
		}

		//B4-P2/25. If_NumbersComparing
		public static void B4_P2_25_If_NumbersComparing()
		{
		}

		//B4-P3/25. If_PositiveNumbersComparing
		public static void B4_P3_25_If_PositiveNumbersComparing()
		{
		}

		//B4-P4/25. If_Akinator5Numbers
		public static void B4_P4_25_If_Akinator5Numbers()
		{

		}

		//B4-P5/25. Switch_DayOfWeek
		public static void B4_P5_25_Switch_DayOfWeek()
		{
		}

		//B4-P6/25. Switch_GameNavigation
		public static void B4_P6_25_Switch_GameNavigation()
		{

		}

		//B4-P7/25. For_10OddEven
		public static void B4_P7_25_For_10OddEven()
		{

		}


		//B4-P8/25. For_3DevideNumbers
		public static void B4_P8_25_For_3DevideNumbers()
		{
		}


		//B4-P9/25. For_Matrix10x10
		public static void B4_P9_25_For_Matrix10x10()
		{

		}


		//B4-P10/25. For_HelloWorld
		public static void B4_P10_25_For_HelloWorld()
		{
		}


		//B4_P11/25. For_Afrochildren
		public static void B4_P11_25_For_Afrochildren()
		{

		}


		//B4-P12/25. For_Minus10OddEven
		public static void B4_P12_25_For_Minus10OddEven()
		{
		}


		//B4-P13/25 For_LettersCount
		public static void B4_P13_25_For_LettersCount()
		{
			Console.WriteLine("Vvedite slovo");
			string word = Console.ReadLine();
			Console.WriteLine("Vvedite bukvu");
			char letter = Console.ReadKey().KeyChar;
			int kol = 0;

			for (int i = 0; i<word.Length; i++)
			{
				if (letter == word[i])
				{
					kol++;
				}
				
			}
			Console.WriteLine();
			Console.WriteLine($"bukva {letter} vstre4aetsya {kol} raz");
		}


		//B4-P14/25 *For_AlphabetBack
		public static void B4_P14_25_For_AlphabetBack()
		{
			//char i = 'z';
			//int birhtYearChar = Convert.ToInt16(i);//"?'
			//char i2 = Convert.ToChar(birhtYearChar);
			//Console.WriteLine($"bukva {i2}");
			int lettera = 97;
			int letterz = 122;
			for (int i= letterz; i>= lettera; i--)
			{
				Console.WriteLine($"{Convert.ToChar(i)}");
			}

		}


		//B4-P15/25 While_OddEventNumber
		public static void B4_P15_25_While_OddEventNumber()
		{

		}


		//B4-P16/25 DoWhile_OddEventNumber
		public static void B4_P16_25_DoWhile_OddEventNumber()
		{

		}


		//B4-P17/25 While_HelloWorld
		public static void B4_P17_25_While_HelloWorld()
		{
		}


		//B4-P18/25 While_Multiplier
		public static void B4_P18_25_While_Multiplier()
		{
			Console.WriteLine("Vvedite 4islo");
			int a = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Vvedite stepen'");
			int b = Convert.ToInt16(Console.ReadLine());
			int i = 1;
			while (i < b)
			{
				i++;
				a=a*a;
			}
			Console.WriteLine(a);
		}


		//B4-P19/25 While_SolveNumberAdding
		public static void B4_P19_25_While_SolveNumberAdding()
		{

		}


		//B4-P20/25 While_DiceGame
		public static void B4_P20_25_While_DiceGame()
		{
			const int itog = 25;
			int sum1 = 0, sum2 = 0;
			string reply;
			var rnd = new Random();
			do
			{
				Console.WriteLine("Бросить кость для Вас?(y/n)");
				do
				{
					reply = Console.ReadLine();
				} while (sum1<itog);

				if (reply == "y")
				{
					var count = rnd.Next(1, 6);
					Console.WriteLine("Выпало {0} очков", count);
					sum1 += count;
					if (sum1 >= itog)
					{
						break;
					}
					if (sum2 < 18)
					{
						count = rnd.Next(1, 5);
						Console.WriteLine("Мне выпало очков {0}", count);
						sum2 += count;
						Console.WriteLine("У меня всего {0} очков", sum1);
						if (sum1 >= itog)
						{
							break;
						}
					}
					else
					{
						Console.WriteLine("Я пас.Будете продолжать? (y/n)");
						do
						{
							reply = Console.ReadLine();
						} while (WaitYesNoInput(reply));
						if (reply.ToUpper() == "N")
						{
							break;
						}
					}

				}
			} while (reply.ToUpper() != "N");
			if (sum1 > itog) Console.WriteLine("Вы проиграли!");
			else if (sum2 > itog) Console.WriteLine("Я проиграл");
			else if (sum1 < sum2) Console.WriteLine("Я выиграл!");
			else if (sum1 == sum2) Console.WriteLine("Ничья!");
			Console.ReadLine();
		}

		private static bool WaitYesNoInput(string reply)
		{
			return !new[] { "Y", "N" }.Contains(reply.ToUpper());
		}




		//B4-P21/25 *While_DiceGameMultiplePlayers
		public static void dB4_P21_25_While_DiceGameMultiplePlayers()
		{

		}


		//B4-P22_25 *While_Akinator100Numbers
		public static void B4_P22_25_While_Akinator100Numbers()
		{

		}


		//B4-P23/25 IfElse_Calcultor
		public static void B4_P23_25_IfElse_Calcultor()
		{

		}


		//B4-P24_25 Switch_Calculator
		public static void B4_P24_25_Switch_Calculator()
		{

		}


		//B4-P25/25 Cycle_WordRevercse
		public static void B4_P25_25_Cycle_WordRevercse()
		{
		}
	}
}
