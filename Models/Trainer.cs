using System.Text.Json.Serialization;

namespace PSDK.Trainer.Generator.Models
{
    public class Trainer
    {
        [JsonPropertyName("klass")]
        public string Klass { get; set; } = "TrainerBattleSetup";
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("dbSymbol")]
        public string DbSymbol { get; set; }
        [JsonPropertyName("trainerName")]
        public string? TrainerName { get; set; }
        public string? TrainerClass { get; set; }
        [JsonPropertyName("vsType")]
        public int VsType { get; set; } = 1;
        [JsonPropertyName("isCouple")]
        public bool IsCouple { get; set; } = false;
        [JsonPropertyName("baseMoney")]
        public int BaseMoney { get; set; } = 20;
        [JsonPropertyName("bagEntries")]
        public List<BagEntry> BagEntries { get; set; } = [];
        [JsonPropertyName("battleId")]
        public int BattleId { get; set; } = 0;
        [JsonPropertyName("ai")]
        public int Ai { get; set; } = 1;
        [JsonPropertyName("party")]
        public List<PartyPokemon?> Party { get; set; } = [];
        [JsonPropertyName("resources")]
        public Resources Resources { get; set; } = new();
    }

    public class BagEntry
    {
        public string DbSymbol { get; set; }
        public int Amount { get; set; }
    }
    public class PartyPokemon
    {
        [JsonPropertyName("specie")]
        public string Species { get; set; }
        [JsonPropertyName("form")]
        public int Form { get; set; } = 0;
        [JsonPropertyName("shinySetup")]
        public ShinySetup ShinySetup { get; set; } = new();
        [JsonPropertyName("levelSetup")]
        public LevelSetup LevelSetup { get; set; } = new();
        [JsonPropertyName("randomEncounterChance")]
        public int RandomEncounterChance { get; set; } = 1;
        [JsonPropertyName("expandPokemonSetup")]
        public List<ExpandPokemonSetup> ExpandPokemonSetup { get; set; } = [];
    }

    public class ShinySetup
    {
        public string Kind { get; set; } = "automatic";
        public int Rate { get; set; } = -1;
    }

    public class LevelSetup
    {
        public string Kind { get; set; } = "fixed";
        public int Level { get; set; } = 5;
    }

    public class ExpandPokemonSetup
    {
        public ExpandPokemonSetup()
        {
            SetupItems =
            [
                new EvsIvsValue() //evs
                {
                    Type = "evs",
                    Value = new()
                    {
                        Hp = 0,
                        Atk = 0,
                        Def = 0,
                        SpAtk = 0,
                        SpDef = 0,
                        Spd = 0
                    }
                },
                new EvsIvsValue() //ivs
                {
                    Type = "ivs",
                    Value = new()
                    {
                        Hp = 0,
                        Atk = 0,
                        Def = 0,
                        SpAtk = 0,
                        SpDef = 0,
                        Spd = 0
                    }
                },

                new LoyaltyValue()
                {
                    Type = "loyalty",
                    Value = 70
                },
                new MovesValue()
                {
                    Type = "moves",
                    Value = new List<string>
                    {
                        "__undef__",
                        "__undef__",
                        "__undef__",
                        "__undef__"
                    }
                },
                new OriginalTrainerName()
                {
                    Type = "originalTrainerName"
                },
                new OriginalTrainerId()
                {
                    Type = "originalTrainerId"
                }
            ];
        }
        public List<SetupItem> SetupItems { get; set; } = [];
    }

    public class Resources
    {
        [JsonPropertyName("sprite")]
        public string? Sprite { get; set; }
        [JsonPropertyName("artworkFull")]
        public string? ArtworkFull { get; set; }
        [JsonPropertyName("artworkSmall")]
        public string? ArtworkSmall { get; set; }
        [JsonPropertyName("character")]
        public string? Character { get; set; }
        [JsonPropertyName("musics")]
        public Musics Musics { get; set; } = new();
    }

    public class Musics
    {
        [JsonPropertyName("encounter")]
        public string? Encounter { get; set; }
        [JsonPropertyName("victory")]
        public string? Victory { get; set; }
        [JsonPropertyName("defeat")]
        public string? Defeat { get; set; }
        [JsonPropertyName("bgm")]
        public string? Bgm { get; set; }
    }
}
