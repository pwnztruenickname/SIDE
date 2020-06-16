using System.Collections.Generic;

namespace SIDE.Model
{
    /// <summary>
    /// Персонаж
    /// </summary>
    public class Character
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long UserId { get; set; }

        public ICollection<CharacterClass> CharacterClasses { get; set; }
    }
}