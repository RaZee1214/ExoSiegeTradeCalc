using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSiegeTradeCalc
{
    public class SaveData
    {
        private static readonly string saveFilePath = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ExoSiegeTradeCalc", "saveData.json");

        public static async Task SaveAsync(List<Trade> trades)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(saveFilePath));
            string json = System.Text.Json.JsonSerializer.Serialize(trades);
            await File.WriteAllTextAsync(saveFilePath, json);
        }

        public static async Task<List<Trade>> LoadAsync()
        {
            if (!File.Exists(saveFilePath))
            {
                return new List<Trade>();
            }
            string json = await File.ReadAllTextAsync(saveFilePath);
            return System.Text.Json.JsonSerializer.Deserialize<List<Trade>>(json) ?? new List<Trade>();
        }
    }
}
