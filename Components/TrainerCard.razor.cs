using Microsoft.AspNetCore.Components;
using PSDK.Trainer.Generator.Models;
namespace PSDK.Trainer.Generator.Components
{
    public partial class TrainerCard
    {
        [Parameter]
        public PokeTrainer? Trainer { get; set; } = default;
    }
}
