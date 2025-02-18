using System.Numerics;

namespace ConsoleAlgorithmCalculatingTheFunctionValue_001
{
	internal class Program
	{
		static void Main(string[] args)
		{
			{
				// Вычисляем значение выражения (F(2024) - F(2023)) / F(2022)
				long result = (long)CalculateExpression(2024);
				Console.WriteLine($"Результат: {result}");
			}

			// Оптимизация кода
			// Поскольку мы знаем, что результат равен 2023^2,
			// можно написать более оптимизированный код без необходимости вычислять огромные факториалы:
			{
				int n = 2024;
				long result = (long)(n - 1) * (n - 1); // 2023 * 2023
				Console.WriteLine($"Результат: {result}");
			}

			Console.ReadKey();
		}

		/// <summary>
		/// Метод для вычисления факториала числа n
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static BigInteger Factorial(int n)
		{
			BigInteger result = 1;
			for (int i = 2; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}

		/// <summary>
		/// Метод для вычисления значения выражения
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static BigInteger CalculateExpression(int n)
		{
			// Вычисляем F(n), F(n-1), F(n-2)
			BigInteger F_n = Factorial(n);
			BigInteger F_n_minus_1 = Factorial(n - 1);
			BigInteger F_n_minus_2 = Factorial(n - 2);

			// Вычисляем (F(n) - F(n-1)) / F(n-2)
			BigInteger numerator = F_n - F_n_minus_1;
			BigInteger denominator = F_n_minus_2;

			return numerator / denominator;
		}
	}
}
