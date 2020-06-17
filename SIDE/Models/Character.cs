using System.Collections.Generic;

namespace SIDE.Models
{
    /// <summary>
    /// Персонаж
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Идентификатор персонажа
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Наименование персонажа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Идентификатор альянса
        /// </summary>
        public long? AllianceId { get; set; }

        /// <summary>
        /// Классы персонажа
        /// </summary>
        public ICollection<CharacterClass> CharacterClasses { get; set; }

        /// <summary>
        /// Мероприятия
        /// </summary>
        public ICollection<CharacterActivity> CharacterActivities { get; set; }
    }
}