using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleAppAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task.Run(TaskAsync).Wait();

           
        }

        static async Task TaskAsync()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Message");
            string message = Console.ReadLine();
            HttpClient client = new HttpClient();
            var StringContent = new StringContent(JsonConvert.SerializeObject(new Details(name, email, message)), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost:51964/api/Contact", StringContent);
            var result = await response.Content.ReadAsStringAsync();
        }

        public class Details
        {
            public string Name { get; set; }
            public string EmailAddress { get; set; }
            public string Message { get; set; }

            public Details(string name, string email, string message)
            {
                this.Name = name;
                this.EmailAddress = email;
                this.Message = message;
            }
        }
    }
}
