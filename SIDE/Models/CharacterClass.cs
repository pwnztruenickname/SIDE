namespace SIDE.Models
{
    /// <summary>
    /// Промежуточная таблица для связи <see cref="Models.Character"/> и <see cref="Models.Class"/>
    /// </summary>
    public class CharacterClass
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор персонажа
        /// </summary>
        public long CharacterId { get; set; }

        /// <summary>
        /// Персонаж
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long ClassId { get; set; }

        /// <summary>
        /// Класс
        /// </summary>
        public Class Class { get; set; }

        /// <summary>
        /// Уровень прокаченности класса
        /// </summary>
        public int Level { get; set; }
    }
}