using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BizarreStatusServer.Models
{
    public class Role
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("uuid")]
        public string Uuid { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("avatar_id")]
        public int AvatarId { get; set; }

        [Column("job_id")]
        public int JobId { get; set; }

        [Column("element_id")]
        public int ElementId { get; set; }

        [Column("weapon_type_id")]
        public int WeaponTypeId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("level")]
        public int Level { get; set; }

        [Column("exp")]
        public int Exp { get; set; }

        [Column("hp")]
        public int Hp { get; set; }

        [Column("mp")]
        public int Mp { get; set; }

        [Column("strength")]
        public int Strength { get; set; }

        [Column("vitality")]
        public int Vitality { get; set; }

        [Column("intelligence")]
        public int Intelligence { get; set; }

        [Column("mentality")]
        public int Mentality { get; set; }

        [Column("dexterity")]
        public int Dexterity { get; set; }

        [Column("speed")]
        public int Speed { get; set; }

        [Column("luck")]
        public int Luck { get; set; }
    }
}
