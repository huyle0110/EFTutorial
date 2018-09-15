using NinjaDomain.Classes.Eums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NinjaDomain.Classes
{
    public class Ninja
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ServedinOniwaban { get; set; }
        public Clan Clan { get; set; }
        public int ClanID { get; set; }
        public List<NinjaEquipment> EquimentOwned { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class Clan
    {
        public int Id { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninjas { get; set; }
    }

    public class NinjaEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquimentType  Type { get; set; }
        [Required]
        public Ninja Ninja { get; set; }
    }
}
