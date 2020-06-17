using System;
using System.Collections.Generic;
using SIDE.Models.Enums;

namespace SIDE.Models
{
    /// <summary>
    /// Мероприятие
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Идентификатор мероприятия
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Наименование мероприятия
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата и время проведения
        /// </summary>
        public DateTime ActivityDateTime { get; set; }

        /// <summary>
        /// Идентификатор альянса
        /// </summary>
        public long? AllianceId { get; set; }

        /// <summary>
        /// Тип мероприятия
        /// </summary>
        public ActivityType ActivityType { get; set; }

        /// <summary>
        /// Организатор мероприятия
        /// </summary>
        public Character Organiser { get; set; }

        public long? OrganiserId { get; set; }

        /// <summary>
        /// Участники мероприятия
        /// </summary>
        public ICollection<CharacterActivity> CharacterActivities { get; set; }
    }
}