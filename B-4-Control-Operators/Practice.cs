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

			int lettera = 97;
			int letterz = 122;
			for (int i= letterz; i>= lettera; i--)
			{
				Console.WriteLine($"{Convert.ToChar(i)}");
			}

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


		//B4-P20/25 While_DiceGame
		public static void B4_P20_25_While_DiceGame()
		{
			const int itog = 25;
			int sum = 0;
			var rnd = new Random();
			int i=0;
			while(sum<itog){
				i++;
				var count = rnd.Next(1, 6);	
				sum +=count;
				Console.WriteLine($"На {i} шаге выпало {count} очков. Всего {sum}");
			}
		}	




		//B4-P21/25 *While_DiceGameMultiplePlayers
		public static void dB4_P21_25_While_DiceGameMultiplePlayers()
		{
			const int itog = 25;
			int sum1 = 0, sum2 = 0;
			var rnd = new Random();
			int i1=0,i2=0;
			while(sum1<itog||sum2<itog){
				i1++;
				i2++;
				var count1 = rnd.Next(1, 6);	
				sum1 +=count1;
				Console.WriteLine($"1 игроку на {i1} шаге выпало {count1} очков. Всего {sum1} очков");
				var count2 = rnd.Next(1, 6);	
				sum2 +=count2;
				Console.WriteLine($"2 игроку на {i2} шаге выпало {count2} очков. Всего {sum2} очков");
				if (sum2>=itog&sum1>=itog){
					Console.WriteLine($"2 игрок набрал на {i2} шаге {sum2} очков.Ничья");
					Console.WriteLine($"1 игрок набрал на {i1} шаге {sum1} очков.Ничья");
					break;
				}
				if (sum1>=itog){
					Console.WriteLine($"1 игрок победил на {i1} шаге, набрав {sum1} очков");
					Console.WriteLine($"2 игрок проиграл на {i2} шаге, набрав {sum2} очков");
					break;
				}
				if (sum2>=itog){
					Console.WriteLine($"2 игрок победил на {i2} шаге, набрав {sum2} очков");
					Console.WriteLine($"1 игрок проиграл на {i1} шаге, набрав {sum1} очков");
					break;
				}
				
			}
		}


		//B4-P22_25 *While_Akinator100Numbers
		public static void B4_P22_25_While_Akinator100Numbers()
		{
			 Console.WriteLine("Загадайте число от 1 до 100");
            Console.ReadKey();
 
            int n = 50, half = 25, i = 1;
            char reply;
                while (i<10)
                {
                    Console.WriteLine($"Ваше число меньше, больше или равно {n}? (</>/=)");
		            reply=Console.ReadKey().KeyChar;
					Console.WriteLine();
                    if (reply== '=')
                    {
                        Console.WriteLine($"Я угадал число {n} c {i} раза");
                        break;
                    }
                    else if (reply== '>')
                    {
                        n = n + half;
                    }
                    else if (reply== '<')
                    {
                        n = n - half;
                    } 
                    
                    i++;
                    half = half / 2+1;
                }
           Console.ReadKey();
		}


		//B4-P25/25 Cycle_WordRevercse
		public static void B4_P25_25_Cycle_WordRevercse()
		{
			Console.WriteLine("Vvedite slovo");
			string word = Console.ReadLine();
			for (int i = word.Length-1; i>=0; i--)
			{
				Console.WriteLine($"{word[i]}");
				
			}
			Console.WriteLine();
			
		}
	}
}
