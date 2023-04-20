//https://learn.microsoft.com/ko-kr/dotnet/csharp/tour-of-csharp/
//https://learn.microsoft.com/ko-kr/dotnet/csharp/tour-of-csharp/types






// // // using System;

// // // class hello
// // // {
// // //     static void main()
// // //     {
// // //         Console.WriteLine("Hello World");
// // //     }
// // // }

// // internal class Program
// // {
// //     private static void Main(string[] args)
// //     {
// //         int i = 123;
// //         object o = i;
// //         int j = (int)o;
// //     }
// // }

// namespace Acme.Collections;

// public class Stack<T>
// {
    

//     public void Push(T data)
//     {
//         _top = new Entry(_top, data);
//     }

//     public T pop()
//     {
//         if (_top == null)
//         {
//             throw new InvaildOperationExpection();
//         }
//         T result = _top.data;
//         _top = _top.data;

//         return result;
//     }

//     class Entry
//     {
//         public Entry Next { get; set; }
//         public T Data { get; set; }

//         public Entry(Entry next, T data)
//         {
//             Next = next;
//             Data = data;
//         }
//     }
// }

public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y) => (X, Y) = (x, y);
}