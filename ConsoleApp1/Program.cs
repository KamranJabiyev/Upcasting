using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

Console.WriteLine("Hello World");

#region Virtual method - overriding
//Animal shark = new Shark();
//Console.WriteLine(shark);
//shark.Eat();
//ILive eagle=new Eagle();
//eagle.
#endregion

#region Single responsibility
//int GetSumofOdd(int[] arr)
//{
//    int result = 0;
//    foreach (int item in arr)
//    {
//        if (GetOdd(item))
//        {
//            result += item;
//        }
//    }
//    return result;
//}

//bool GetOdd(int num)
//{
//    return num % 2 != 0;
//}
#endregion


#region Person Sort

//Person person1 = new();
//person1.Age = 20;
//Person person2 = new();
//person2.Age = 10;
//Person person3 = new();
//person3.Age = 50;
//Person person4 = new();
//person4.Age = 120;

//Person[] people = {person2 , person1, person3, person4 };


//for (int j = 0; j < people.Length - 1; j++)
//{
//    if (people[j] > people[j + 1])
//    {
//        Person temp = people[j];
//        people[j] = people[j + 1];
//        people[j + 1] = temp;
//    }
//}

//foreach (Person item in people)
//{
//    Console.WriteLine(item.Age);
//}

// 1, 12, 7, 5

// 1, 7, 5, 12

// 1, 5, 7, 12

#endregion
