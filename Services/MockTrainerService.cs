using Newtonsoft.Json;
using PSDK.Trainer.Generator.Models;

namespace PSDK.Trainer.Generator.Services
{
    public class MockTrainerService : IMockTrainerService
    {
        private readonly string _dataPath = @"MockData\Trainers";
        public async Task<List<PokeTrainer>> GetPokeTrainersAsync()
        {
            var trainers = new List<PokeTrainer>();

            foreach (var file in Directory.GetFiles(_dataPath))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    var jsonString = await reader.ReadToEndAsync();
                    var trainer = JsonConvert.DeserializeObject<PokeTrainer>(jsonString);
                    trainers.Add(trainer);
                }
            }

            return trainers;
        }

        public async Task<PokeTrainer?> GetPokeTrainerByIdAsync(string id)
        {
            PokeTrainer? trainer = null;

            foreach (var file in Directory.GetFiles(_dataPath))
            {
                using (StreamReader reader = new(file))
                {
                    var jsonString = await reader.ReadToEndAsync();
                    var currentTrainer = JsonConvert.DeserializeObject<PokeTrainer>(jsonString);

                    if (currentTrainer?.Id.ToString() == id)
                    {
                        trainer = currentTrainer;
                        break; 
                    }
                }
            }

            return trainer;
        }
    }
}
