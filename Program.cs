using System;

namespace Zscno.Sanfo
{
    internal class Program
    {
        private static ConsoleColor _color;
		
        static void Main(string[] args)
		{
			_color = Console.ForegroundColor;
			string[] letters =
			[
				"a", "b", "c", "d", "e", "f", "g","h", "i", "j", "k", "l", "m",
				"n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
			];
			Random random = new();
			bool isContinue;
			int length;

			do
			{
				// 获取生成数量。
				while (true)
				{
					Console.WriteLine("Please enter the number of letters you want to generate:\n"
						+ "请输入你想生成的字母数量：");
					if (!int.TryParse(Console.ReadLine(), out length))
					{
						Remind();
					}
					else
					{
						break;
					}
				}

				// 生成。
				Console.ForegroundColor = ConsoleColor.Blue;
				for (int i = 0; i < length; i++)
				{
					Console.Write(letters[random.Next(0, 25)]);
				}
				Console.ForegroundColor = _color;
				Console.WriteLine();

				// 判断是否继续。
				while (true)
				{
					Console.WriteLine("Do you want to continue? [1 means yes/2 means no]\n"
						+ "你想继续吗？[1表示继续/2表示退出]");

					string? decideContinue = Console.ReadLine();
					if (decideContinue == "2")
					{
						isContinue = false;
						break;
					}
					else if (decideContinue == "1")
					{
						isContinue = true;
						break;
					}
					else
					{
						Remind();
					}
				}
			} while (isContinue);
		}

		/// <summary>
		/// 提醒用户输入的数字不正确。
		/// </summary>
		private static void Remind()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("Please enter a right number.\n请输入正确的数字。");
			Console.ForegroundColor = _color;
		}
    }
}
