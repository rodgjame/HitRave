using System;

namespace HitRave.Models
{
    /// <summary>
    /// Sets the User type. Used for access levels
    /// </summary>
    public enum UserTypeModel
    {
        Admin = 1,
        User = 2
    }

    /// <summary>
    /// Model to represent a user in the system
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the active date time.
        /// </summary>
        /// <value>
        /// The active date time.
        /// </value>
        public DateTime ActiveDateTime { get; set; }

        /// <summary>
        /// Gets or sets the inactive date time.
        /// </summary>
        /// <value>
        /// The inactive date time.
        /// </value>
        public DateTime? InactiveDateTime { get; set; }

        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        /// <value>
        /// The type of the user. <see cref="UserTypeModel"/>
        /// </value>
        public UserTypeModel UserType { get; set; }

        /// <summary>
        /// Gets or sets the user's email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }
    }
}