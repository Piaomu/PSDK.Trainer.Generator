using PSDK.Trainer.Generator.Models;

namespace PSDK.Trainer.Generator.Services
{
    public interface IMockTrainerService
    {
        public Task<List<PokeTrainer>> GetPokeTrainersAsync();
        public Task<PokeTrainer> GetPokeTrainerByIdAsync(string id);
    }
}
