/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

using static System.Console;
Console.Clear();
int M = AskNumber("M");
int N = AskNumber("N");
WriteLine($"M = {M}; N = {N}. -> \"{PrintRange(M, N)}\"");

static string PrintRange(int M, int N) {
    if(N < M) {
        return "";
    }
    string part = N == M ? $"{N}" : $"{N}, ";
    return part + PrintRange(M, N - 1);
}

static int AskNumber(string name) {
    Write($"Ввеcсти число {name}: ");
    return int.Parse(ReadLine());
}


/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
int m = InputNumbers("Ввести m: ");
int n = InputNumbers("Ввести n: ");
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
PrintSumm(m, n, temp=0);
void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}



/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

Console.Clear();
int m = InputNumbers("Ввести m: ");
int n = InputNumbers("Ввести n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


