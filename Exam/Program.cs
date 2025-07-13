namespace Exam
{
    internal class Program
    {
        
       
        
        static void Main(string[] args)
        {
            #region Q1
            // Console.WriteLine("Enter Age : ");
            // int Age = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter Nationality : ");
            // string Nationality = Console.ReadLine();

            // if (Age >= 18 && Nationality == "Egyption") Console.WriteLine("Eligible To Vote");
            // else Console.WriteLine("Not Eligible To Vote");
            #endregion
            #region Q2
            // //2 
            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //double Result = Calc(num1, num2, op);
            //if (Result != int.MinValue)
            //{
            //    Console.WriteLine($"result is : {Result}");
            //}

            //    double Calc(double num1, double num2, char op)
            //{

            //    double result;
            //    switch (op)
            //    {
            //        case '+':
            //            return result = num1 + num2;


            //        case '-':
            //            return result = num1 - num2;


            //        case '*':
            //            return result = num1 * num2;


            //        case '/':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Error: Cannot divide by zero.");
            //                return int.MinValue;

            //            }
            //            else
            //            {
            //                return result = num1 / num2;

            //            }


            //        default:
            //            Console.WriteLine("Invalid operator.");
            //            return int.MinValue;

            //    }
            //}
            #endregion
            #region Q3
            //3
            // void PrintMultiplicationTable(int n)
            // {
            //     for (int i = 1; i <= n; i++)
            //     {
            //         Console.WriteLine($"{i} * {n} = {i*n}");
            //     }
            // }
            // Console.WriteLine("Please Enter Num :");
            //int n = int.Parse(Console.ReadLine());
            // PrintMultiplicationTable(n);
            #endregion
            #region Q4
            //4
            //bool IsPrime(int n)
            //{
            //    if (n < 2) return false;

            //    for (int i = 2; i <= Math.Sqrt(n); i++)
            //    {
            //        if (n % i == 0)
            //            return false;
            //    }

            //    return true;
            //}
            //int Count = 0;
            //int[] arr = { 3, 5, 7, 8, 9, 6, 2, 4 };
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (IsPrime(arr[i])) Count++;

            //}
            //Console.WriteLine($"Num Of Prime Nums in this Array is : {Count}");
            #endregion
            #region Q5
            //5
            // int [] arr = new int [10];
            //for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine ($"please Enter Num {i+1} : ");
            //     arr [i] = int.Parse(Console.ReadLine());
            // }
            // int max = arr[0];
            // int index = -1;
            //for(int i = 0;i < arr.Length;i++)
            // {
            //     if (arr [i] > max)
            //     {
            //         max = arr[i];
            //         index = i;
            //     }

            // }
            // Console.WriteLine($"Max Num Is : {max} and its index is{index}");
            #endregion
            #region Q6
            //6

            //bool IsPalindrome(string palindrome)
            //{
            //    palindrome = palindrome.ToLower();
            //    for (int i = 0; i < palindrome.Length / 2; i++)
            //    {
            //        if ((palindrome[i]) != palindrome[palindrome.Length - 1 - i]) return false;

            //    }
            //    return true;
            //}

            //Console.WriteLine($"Please Enter String : ");
            //string str = Console.ReadLine();
            //if (IsPalindrome(str)) Console.WriteLine("Your string is palindrome");
            //else Console.WriteLine("Your string is not palindrome");
            #endregion
            #region Q7
            ////7
            //int? result(int? Num1, int? Num2)
            //{
            //    if (Num1 == null || Num2 == null) return null;
            //    else if (Num1 != null || Num2 != null || Num2 != 0) return Num1 / Num2;
            //    else return null;
            //}
            //string input1;
            //string input2;

            //do
            //{
            //    Console.WriteLine("Please Enter Num1");
            //    input1 = Console.ReadLine();
            //    Console.WriteLine("Please Enter Num2");
            //    input2 = Console.ReadLine();

            //} while (String.IsNullOrEmpty(input1) || String.IsNullOrEmpty(input2));
            //int? Result= result(int.Parse(input1), int.Parse(input2));
            #endregion
            #region Q8
            //8
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //int sum = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i] %2==0)
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Sum of Even Nums Is {sum}");
            #endregion
            #region Q9
            // 9
            //int Score = 0;
            //bool Result;
            //do
            //{
            //    Console.WriteLine("Please Enter Score Between(1-100)");
            //    Result = int.TryParse(Console.ReadLine(), out Score);
            //} while (!Result && Score >= 0 && Score <= 100);
            //switch (Score)
            //{
            //    case  >= 90 and <= 100:
            //        Console.WriteLine("A");
            //        break;
            //    case >= 80 and < 90:
            //        Console.WriteLine("B");
            //        break;
            //    case >= 70 and < 80:
            //        Console.WriteLine("C");
            //        break;
            //    case >= 60 and < 70:
            //        Console.WriteLine("D");
            //        break;
            //    case < 60:
            //        Console.WriteLine("F");
            //        break;

            //}
            #endregion
            #region Q10
            //10
            //int? ScoreAvg(int []? score)
            //{
            //    int Sum =0;
            //    int Count =0;
            //    for(int i = 0;i<score.Length;i++)
            //    {
            //        if (score[i] != null)
            //        {
            //            Sum += score[i];
            //            Count++;
            //        }
            //    }
            //    if(score > 0)  return Sum/Count;
            //    else return null;
            //}
            #endregion

        }
    }
}
