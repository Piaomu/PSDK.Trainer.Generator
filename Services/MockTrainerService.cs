using PSDK.Trainer.Generator.Models;

namespace PSDK.Trainer.Generator.Services
{
    public class MockTrainerService : IMockTrainerService
    {
        public Task<PokeTrainer> GetPokeTrainerByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PokeTrainer>> GetPokeTrainersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
