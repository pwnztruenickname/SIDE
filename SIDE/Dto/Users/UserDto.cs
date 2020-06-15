namespace SIDE.Dto.Users
{

    /// <summary>
    /// DTO для работы с пользователями
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Имя персонажа в игре
        /// </summary>
        public string CharacterName { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }
    }
}