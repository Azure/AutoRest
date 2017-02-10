
namespace Petstore.Models
{
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public partial class User
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User() { }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="userStatus">User Status</param>
        public User(long? id = default(long?), string username = default(string), string firstName = default(string), string lastName = default(string), string email = default(string), string password = default(string), string phone = default(string), int? userStatus = default(int?))
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
            UserStatus = userStatus;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets user Status
        /// </summary>
        [JsonProperty(PropertyName = "userStatus")]
        public int? UserStatus { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != Id )
            {
                result.Add(new XElement("id", Id) );
            }
            if( null != Username )
            {
                result.Add(new XElement("username", Username) );
            }
            if( null != FirstName )
            {
                result.Add(new XElement("firstName", FirstName) );
            }
            if( null != LastName )
            {
                result.Add(new XElement("lastName", LastName) );
            }
            if( null != Email )
            {
                result.Add(new XElement("email", Email) );
            }
            if( null != Password )
            {
                result.Add(new XElement("password", Password) );
            }
            if( null != Phone )
            {
                result.Add(new XElement("phone", Phone) );
            }
            if( null != UserStatus )
            {
                result.Add(new XElement("userStatus", UserStatus) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of User
        /// </summary>
        internal static User XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static User XmlDeserialize(XElement payload)
        {
            var result = new User();
            var deserializeId = XmlSerialization.ToDeserializer(e => (long?)e);
            long? resultId;
            if (deserializeId(payload, "id", out resultId))
            {
                result.Id = resultId;
            }
            var deserializeUsername = XmlSerialization.ToDeserializer(e => (string)e);
            string resultUsername;
            if (deserializeUsername(payload, "username", out resultUsername))
            {
                result.Username = resultUsername;
            }
            var deserializeFirstName = XmlSerialization.ToDeserializer(e => (string)e);
            string resultFirstName;
            if (deserializeFirstName(payload, "firstName", out resultFirstName))
            {
                result.FirstName = resultFirstName;
            }
            var deserializeLastName = XmlSerialization.ToDeserializer(e => (string)e);
            string resultLastName;
            if (deserializeLastName(payload, "lastName", out resultLastName))
            {
                result.LastName = resultLastName;
            }
            var deserializeEmail = XmlSerialization.ToDeserializer(e => (string)e);
            string resultEmail;
            if (deserializeEmail(payload, "email", out resultEmail))
            {
                result.Email = resultEmail;
            }
            var deserializePassword = XmlSerialization.ToDeserializer(e => (string)e);
            string resultPassword;
            if (deserializePassword(payload, "password", out resultPassword))
            {
                result.Password = resultPassword;
            }
            var deserializePhone = XmlSerialization.ToDeserializer(e => (string)e);
            string resultPhone;
            if (deserializePhone(payload, "phone", out resultPhone))
            {
                result.Phone = resultPhone;
            }
            var deserializeUserStatus = XmlSerialization.ToDeserializer(e => (int?)e);
            int? resultUserStatus;
            if (deserializeUserStatus(payload, "userStatus", out resultUserStatus))
            {
                result.UserStatus = resultUserStatus;
            }            return result;
        }
    }
}

