using System.Collections.Generic;

namespace SIDE.Models
{
    /// <summary>
    /// Альянс
    /// </summary>
    public class Alliance
    {
        /// <summary>
        /// Идентификатор альянса
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Наименование альянса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Участники альянса
        /// </summary>
        public ICollection<Character> Characters { get; set; }

        /// <summary>
        /// Мероприятия альянса
        /// </summary>
        public ICollection<Activity> Activities { get; set; }
    }
}