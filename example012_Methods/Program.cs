//Вид 1 - ничего не принимает, ничего не возвращает
//void Method1()
//{
    //Console.WriteLine("Автор...");
//}
//Method1();

//Вид 2 - что-то принимает, ничего не возвращает
//void Method2(string msg)
//{
  //  ConsoleWriteLine(msg);
//}
//Method2(msg: "Введите текст сообщения");

//void Method21(string msg, int count)
//{
  //  int i = 0;
    //while (i < count);
    //{
      //  Console.WriteLine(msg);
        //i++;
    //}
//}
//Method21("Текст", count: 4);

//Вид 3- ничего не принимают, ничего не возвращают
//int Method3()
//{
  //  return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);

//Вид 4 - что то принимают, что то возвращают
//string Method4(int count, string text)
//{
  //  int i = 0;
    //string result = String.Empty;
    //while( i < count)
   // {
    //    result = result + text;
   //     i++;
   // }
   // return result;
//}
//string res = Method4(10, "a,s,d,f");
//Console.WriteLine(res);

//Цикл For

//string Method4(int count, string text)
//{
  //  string result = String.Empty;
    //for (int i = 0; i < count; i++)
    //{
      //  result = result + text;
    //}
    //return result;
//}
//string res = Method4(10, "a,s,d,f");
//Console.WriteLine(res);

//Цикл в цикле
 for (int i = 2; i <= 10; i++)
 {
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
 }