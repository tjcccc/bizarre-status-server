using System.ComponentModel.DataAnnotations.Schema;

namespace BizarreStatusServer.Models
{
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("level")]
        public int Level { get; set; }

        [Column("phone")]
        public string Phone { get; set; }
    }
}
