// Task 1 mürekkeb ededleri ekrana çıxaran program 

//int[] arr = { 2, 1, 6, 8, 14 };
//for (int i = 0; i < arr.Length; i++)
//{
//           for (int j = 2; j < arr[i]; j++)
//        {
//            if (arr[i] % j == 0)
//            {
//                Console.WriteLine(arr[i]);
//                break;
//            }
//        }

//}



// her iki arrrayda olan elemntleri ekrana cıxaran program

//int[] arr1 = { 5, 6, 11, 9 };
//int[] arr2 = { 5, 11, 7, 0 };

//for (int i = 0; i < arr1.Length; i++)
//{
//    for (int j = 0; j < arr2.Length; j++)
//    {
//        if (arr1[i] == arr2[j])
//        {
//            Console.WriteLine(arr1 [i]);
//        }
//    }
//}



// arrayın en böyük ve en kicik elemntlerinin indexlerini ekrana cıxaran program

//int[] arr = { 5, 1, 4, 10, 9, 2 };
//int arrMax = arr[0];
//int arrMin = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > arrMax)
//    {
//        arrMax = arr[i];
//        Console.WriteLine(i);

//    }
//    if (arr[i] < arrMin)
//    {
//        arrMin = arr[i];
//        Console.WriteLine(i);

//    }

//}



// ededin mertebelerinin cemini tapan alqoritm 

//Console.WriteLine("ededi daxil edin: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//while (num > 0)
//{
//    int m = num % 10;
//    sum += m;
//    num /= 10;
//}
//Console.WriteLine(sum);






// optional 

//int[] arr = { 4, 1, 9, 6, 10, 2, 5, 8, 3 };
//int sum = 0;
//int expectedSum = 0;
//for (int i = 0; i < arr.Length; i++)
//{

//    sum += arr[i];
//}
//for (int j = 0; j <= 10; j++)
//{
//    expectedSum += j;
//}
//int wantedNumber = expectedSum - sum;
//Console.WriteLine(wantedNumber);



