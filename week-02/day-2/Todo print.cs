using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo
            Console.WriteLine(MyTodoText(todoText));
            Console.ReadLine();
 
        }
        public static string MyTodoText (string MyTodo)
        {
            string todoText = " - Buy milk\n";

            MyTodo = todoText.Insert(0, "My Todo: \n");
            int index = MyTodo.Length; // = 22
            string MyTodo2 = MyTodo.Insert(index, " - Download games\n");
            int indexLast = MyTodo2.Length;
            string MyTodo3 = MyTodo2.Insert(indexLast, "\t- Diablo");

            return MyTodo3;

        }        
    }
}
