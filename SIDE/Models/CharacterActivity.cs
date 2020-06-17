namespace SIDE.Models
{
    /// <summary>
    /// Промежуточная таблица для сущностей <see cref="Character"/> и <see cref="Activity"/>
    /// </summary>
    public class CharacterActivity
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
        /// Идентификатор мероприятия
        /// </summary>
        public long ActivityId { get; set; }

        /// <summary>
        /// Мероприятие
        /// </summary>
        public Activity Activity { get; set; }
    }
}