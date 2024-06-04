namespace PSDK.Trainer.Generator.Models
{
    public class Trainer
    {
        public string Klass { get; set; } = "TrainerBattleSetup";
        public int Id { get; set; }
        public string DbSymbol { get; set; }
        public int VsType { get; set; }
        public bool IsCouple { get; set; }
        public int BaseMoney { get; set; }
        public List<int> BagEntries { get; set; } = [];
        public int BattleId { get; set; }
        public int Ai { get; set; }
        public List<Pokemon?> Party { get; set; } = [];
        public Resources Resources { get; set; } = new();
    }

    public class Pokemon
    {
        public string Specie { get; set; }
        public int Form { get; set; }
        public ShinySetup ShinySetup { get; set; } = new();
        public LevelSetup LevelSetup { get; set; } = new();
        public int RandomEncounterChance { get; set; }
        public List<ExpandPokemonSetup> ExpandPokemonSetup { get; set; } = new List<ExpandPokemonSetup>();
    }

    public class ShinySetup
    {
        public string Kind { get; set; }
        public int Rate { get; set; }
    }

    public class LevelSetup
    {
        public string Kind { get; set; }
        public int Level { get; set; }
    }

    public class ExpandPokemonSetup
    {
        public string Type { get; set; }
        public object Value { get; set; } // Using 'object' to accommodate different value types
    }

    public class Resources
    {
        public string? Sprite { get; set; }
        public string? ArtworkFull { get; set; }
        public string? ArtworkSmall { get; set; }
        public string? Character { get; set; }
        public Musics Musics { get; set; } = new();
    }

    public class Musics
    {
        public string? Encounter { get; set; }
        public string? Victory { get; set; }
        public string? Defeat { get; set; }
        public string? Bgm { get; set; }
    }
}
