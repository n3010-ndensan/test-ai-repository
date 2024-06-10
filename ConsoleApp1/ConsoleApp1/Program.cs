using System;

namespace ConsoleApp {
	class Program {
		static void Main(string[] args) {

			int tmp = 0;

			// 1から50までの数値を出力
			for (int i = 1; i <= 50; i++) {
				Console.WriteLine("Number: " + i);

				// 偶数か奇数かを判定
				if (IsEven(i)) {
					Console.WriteLine(i + " is an even number.");
				} else {
					Console.WriteLine(i + " is an odd number.");
				}

				// 空行を出力
				Console.WriteLine();
			}

			// プログラムの終了を待つ
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		// 数値が偶数かどうかを判定するメソッド
		static bool IsEven(int number) {
			return number % 2 == 0;
		}
	}
}
