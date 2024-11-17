using System.Net.Http.Json;
using dofus_unity_rendering_back.Models.Metadata.Effect;
using dofus_unity_rendering_back.Models.Metadata.Effect.Instance;
using dofus_unity_rendering_back.Models.Metadata.Monster;
using dofus_unity_rendering_back.Models.Metadata.Spell;
using dofus_unity_rendering_back.Models.Metadata.Translation;
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

        public async static void LoadDataFromJSon(WebApplication app)
        {
             await setupTranslation(app);
             await setupEffects(app);
             await setupMonsters(app);
             await setupSpells(app);
            await setupSpellLevels(app);
        }

        public async static Task setupSpells(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = new AppDbContext(app.Configuration);
                string filePath = "C:\\Users\\enzos\\source\\repos\\dofus-unity-rendering-back\\Data\\SpellsRoot.json";

                string json = File.ReadAllText(filePath);
                string jsonContent = File.ReadAllText(filePath);
                List<Spells> spells = new();
                JObject jsonObject = JObject.Parse(jsonContent);

                JArray items = (JArray)jsonObject["references"]["RefIds"];
                foreach (var item in items)
                {
                    spells.Add(item["data"].ToObject<Spells>());
                }

                dbContext.SpellsRecords.AddRange(spells);
                await dbContext.SaveChangesAsync();
            }
        }
        public async static Task setupSpellLevels(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = new AppDbContext(app.Configuration);
                string filePath = "C:\\Users\\enzos\\source\\repos\\dofus-unity-rendering-back\\Data\\SpellLevelsRoot.json";

                string json = File.ReadAllText(filePath);
                string jsonContent = File.ReadAllText(filePath);
                List<SpellLevels> spellLevels = new();
                List<EffectInstanceDice> effectInstanceDices = new();
                JObject jsonObject = JObject.Parse(jsonContent);

                JArray items = (JArray)jsonObject["references"]["RefIds"];
                foreach (var item in items)
                {
                    spellLevels.Add(item["data"].ToObject<SpellLevels>());
                    JArray effectInstanceDicesObject = (JArray)item["data"]["effects"];

                    foreach (var effectInstanceDice in effectInstanceDicesObject)
                    {
                        effectInstanceDices.Add(effectInstanceDice.ToObject<EffectInstanceDice>());
                    }
                }

                dbContext.SpellLevelsRecords.AddRange(spellLevels);
                dbContext.EffectInstanceDiceRecords.AddRange(effectInstanceDices);
                await dbContext.SaveChangesAsync();
            }
        }

        public async static Task setupTranslation(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = new AppDbContext(app.Configuration);
                string[] languages = { "fr", "en", "es", "de", "pt" };
                List<TranslatedLabel> translations = new();
                foreach (var l in languages)
                {
                    string filePath = "C:\\Users\\enzos\\source\\repos\\dofus-unity-rendering-back\\Data\\i18n\\" + l + ".i18n.json";

                    string json = File.ReadAllText(filePath);
                    string jsonContent = File.ReadAllText(filePath);


                    JObject jsonObject = JObject.Parse(jsonContent);

                    JObject entries = (JObject)jsonObject["entries"];
                    foreach (var item in entries)
                    {
                        translations.Add(new TranslatedLabel(int.Parse(item.Key), l, (string)item.Value));
                    }
                }


                dbContext.TranslatedLabelRecords.AddRange(translations);
                await dbContext.SaveChangesAsync();
                Console.WriteLine("ok");
            }
        }

        public async static Task setupEffects(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = new AppDbContext(app.Configuration);
                string filePath = "C:\\Users\\enzos\\source\\repos\\dofus-unity-rendering-back\\Data\\EffectsRoot.json";

                string json = File.ReadAllText(filePath);
                string jsonContent = File.ReadAllText(filePath);
                List<Effects> effects = new();
                JObject jsonObject = JObject.Parse(jsonContent);

                JArray items = (JArray)jsonObject["references"]["RefIds"];
                foreach (var item in items)
                {
                    effects.Add(item["data"].ToObject<Effects>());
                    Console.WriteLine("ok");
                }

                Console.WriteLine("ok");
                dbContext.EffectsRecords.AddRange(effects);
                await dbContext.SaveChangesAsync();
            }
        }


            public async static Task setupMonsters(WebApplication app)
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
