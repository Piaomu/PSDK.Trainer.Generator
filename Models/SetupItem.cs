using System.Text.Json.Serialization;

namespace PSDK.Trainer.Generator.Models
{
    public abstract class SetupItem
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("value")]
        public dynamic? Value { get; set; }
    }


    public class EvsIvsValue : SetupItem
    {
        public new EffortOrIndividualValues Value { get; set; } = new();
    }

    public class LoyaltyValue : SetupItem
    {
        public new int Value { get; set; } = 70;
    }

    public class MovesValue : SetupItem
    {
        public new List<string> Value { get; set; } = [];
    }

    public class OriginalTrainerName : SetupItem
    {
        public new string Value { get; set; } = "Red";
    }
    public class OriginalTrainerId : SetupItem
    {
        public new int Value { get; set; } = 000001;
    }


    public class EffortOrIndividualValues
    {
        [JsonPropertyName("hp")]
        public int Hp { get; set; }

        [JsonPropertyName("atk")]
        public int Atk { get; set; }

        [JsonPropertyName("dfe")]
        public int Def { get; set; }

        [JsonPropertyName("spd")]
        public int Spd { get; set; }

        [JsonPropertyName("ats")]
        public int SpAtk { get; set; }

        [JsonPropertyName("dfs")]
        public int SpDef { get; set; }
    }
}