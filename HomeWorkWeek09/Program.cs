using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWeek09JsonGetToDoURL
{
    internal class Program
    {
        static string Path = @"C:\Users\User\source\repos\HomeWorkWeek09\HomeWorkWeek09\ToDoOutput.txt";
        static async Task Main(string[] args)
        {
            #region JsonGetToDo
            Console.WriteLine("Please enter the URL you want: ");
            string url = Console.ReadLine();
            var awaiter = await GetToDoAsync(url);
            if (awaiter != null)
            {
               File.WriteAllText(Path, awaiter.ToString());
            }
            Console.WriteLine("Press X to Exit");
            Console.ReadKey();
            #endregion JsonGetToDo
        }
        #region JsonGetToDo
        public static async Task<string> GetToDoAsync(string url)
        {
            // const string url = "https://jsonplaceholder.typicode.com/todos/";          
            HttpClient client = new HttpClient();
            var stringResult = await client.GetStringAsync(url);            
            return stringResult;
        }
        #endregion JsonGetToDo
    }
}
