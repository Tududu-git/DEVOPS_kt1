using System;
using System.Text;
using System.LinQ;
using System.IO;

internal class program
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Введите цифру");
    Console.WriteLine("1.посмотреть каталог книг");
    Console.WriteLine("2.удалить книгу");
    Console.WriteLine("3.добавить книгу");
    string answer = Console.ReadLine();
    switch(answer)
    {
      case "1":
        Viev();
        break;
      case "2":
        Add();
        break;
      case "3":
        Remove();
        break;
      default:
        Main();
        break;
    }
  }
  static void Viev()
  {
    
  }
  static void Add()
  {
    
  }
  static void Remove()
  {
    
  }
}
