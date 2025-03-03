using System.Net.Http.Headers;

namespace ConsumingWebAPIDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ShowDepartment(6);
            ShowDepartment(1);
            ShowDepartment(2);
            Console.ReadLine();
        }

        public static async void ShowDepartment(int id)
        {
            //1- Http Client
            //2=URI
            //3-Accept Media JSON /XML    Content-Type=application/json
            //4- Calling Method On Verb Http Get , Post


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5276/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/Departments/" + id);

                if (response.IsSuccessStatusCode)
                {
                    Department dept = await response.Content.ReadAsAsync<Department>();
                    Console.WriteLine($"{dept.departmentId} , Name {dept.Name} , Description {dept.Description}");
                }
            }
        }
    }


    class Department
    {
        public int departmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
