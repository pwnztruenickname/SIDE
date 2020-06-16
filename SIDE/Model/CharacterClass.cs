namespace SIDE.Model
{
    public class CharacterClass
    {
        public long Id { get; set; }

        public long CharacterId { get; set; }

        public Character Character { get; set; }

        public long ClassId { get; set; }

        public Class Class { get; set; }

        public int Level { get; set; }
    }
}