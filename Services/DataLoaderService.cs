using System.Net.Http.Json;
using dofus_unity_rendering_back.Models.Metadata.Monster;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace dofus_unity_rendering_back.Services
{
    public class DataLoaderService
    {
        private readonly AppDbContext _context;

        public DataLoaderService(AppDbContext context)
        {
            _context = context;
        }

        public async Task LoadDataFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            string jsonContent = File.ReadAllText(filePath);
            List<Monsters> monsters = new();
            JObject jsonObject = JObject.Parse(jsonContent);

            JArray items = (JArray)jsonObject["references"]["RefIds"];
            foreach (var item in items)
            {
                monsters.Add(item["data"].ToObject<Monsters>());
            }

            _context.MonstersRecords.AddRange(monsters);
            await _context.SaveChangesAsync();
        }

        public static void LoadDataFromJSon(WebApplication app)
        {

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = new AppDbContext(app.Configuration);
                string filePath = "C:\\Users\\enzos\\source\\repos\\dofus-unity-rendering-back\\Data\\MonstersRoot.json";

                string json = File.ReadAllText(filePath);
                string jsonContent = File.ReadAllText(filePath);
                List<Monsters> monsters = new();
                JObject jsonObject = JObject.Parse(jsonContent);

                JArray items = (JArray)jsonObject["references"]["RefIds"];
                foreach (var item in items)
                {
                    monsters.Add(item["data"].ToObject<Monsters>());
                    Console.WriteLine("ok");
                }

                Console.WriteLine("ok");
                dbContext.MonstersRecords.AddRange(monsters);
                dbContext.SaveChangesAsync();
            }
        }
    }
}
