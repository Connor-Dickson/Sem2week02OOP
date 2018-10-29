using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Week12_API_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(TaskAsync).Wait();
        }

        public static async Task TaskAsync()
        {
            Console.WriteLine("Working...");

            using (HttpClient client = new HttpClient())
            {
                //get
                var getResponse = 
                    await client.GetAsync("http://todoapiswin.azurewebsites.net/api/Todo?apiKey=CRD");
                var stringGetResponse = await getResponse.Content.ReadAsStringAsync();
                var getResponseObject = JsonConvert.DeserializeObject<List<Todos>>(stringGetResponse);

                foreach(var entry in getResponseObject)
                {
                    Console.WriteLine(entry.Id);
                    Console.WriteLine(entry.Task);
                }
                //post
                var taskString = JsonConvert.SerializeObject(new Todos
                {
                    Task =
                    "Gettin Stuff and Things"
                },
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        Formatting = Formatting.None,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()

                    });
                var sendTask = new StringContent(taskString, Encoding.UTF8, "application/json");

                var postResponse = await client.PostAsync("http://todoapiswin.azurewebsites.net/api/Todo?apiKey=CRD",
                    sendTask);


                //put
                var updateString = JsonConvert.SerializeObject(new Todos
                {
                    Task = "Updated"
                },
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        Formatting = Formatting.None,
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    });
                
                var updateTask = new StringContent(updateString, Encoding.UTF8, "application/json");
                var updateResponse = await client.PutAsync("http://todoapiswin.azurewebsites.net/api/Todo/556f812f-44d3-462f-8061-5d03495ec48e?apiKey=CRD", 
                    updateTask);


                //delete
                var deleteResponse = await client.DeleteAsync("http://todoapiswin.azurewebsites.net/api/Todo/95922df0-152a-40a4-8f49-e2e8c8d64e1f?apiKey=CRD");
            }
            Console.ReadLine();
        }
    }
}
