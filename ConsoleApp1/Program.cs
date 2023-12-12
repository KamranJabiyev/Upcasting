using ConsoleApp1.Models;

Console.WriteLine("Hello World");

#region Upcasting,boxing, implicit
//Shark shark = new Shark();
//Eagle eagle = new Eagle();
//int a = 0, b = 0;
//bool isTrue = false;
//object[] objects = {a,b,eagle,shark,isTrue,false,10,null};
//Animal[] animals = { shark, eagle };
//foreach (Animal animal in animals)
//{
//    Console.WriteLine(animal);
//}
#endregion

#region Downcasting, unboxing, explicit
//Shark shark = new Shark();
//Eagle eagle = new Eagle();
//int a = 0, b = 0;
//bool isTrue = false;
//object[] objects = { a, b, eagle, shark, isTrue, false, 10, null };
//foreach (object obj in objects)
//{
//    if (obj is int result)
//    {
//        Console.WriteLine(result + 1);
//    }
//    //int? result=obj as int?;
//    //if(result is not null)
//    //{
//    //    Console.WriteLine(result + 1);
//    //}
//}
#endregion

#region Implicit & explicit operators
//Dollar dollar = new Dollar(100);
//Manat manat = dollar;
//Console.WriteLine(manat.AZN);
#endregion

#region Operator overloading
//int num1 = 20;
//int num2 = 40;
//string word1 = "asdasfd";
//string word2 = "asdasfd";
//Console.WriteLine(word2+word1);
//Console.WriteLine(num2-num1);
//Person p1 = new Person();
//Person p2 = new Person();
//Person p3 = new Person();
//p1.Age = 34;
//p2.Age = 16;
//p3.Age = 26;
//Console.WriteLine(p1 > p2);
//Console.WriteLine(p1 + p2);


//Celsius celsius = new Celsius(100);
//Fahrenheit fahrenheit = celsius;
//Fahrenheit fahrenheit2 = new(56);
//celsius = (Celsius)fahrenheit2;

//Console.WriteLine(fahrenheit.fanarhet);
//Console.WriteLine(celsius.celsius);


#endregion