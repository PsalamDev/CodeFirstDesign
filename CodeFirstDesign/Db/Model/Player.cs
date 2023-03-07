using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDesign.Db.Model
{
    public class Player : IdentityUser
    {
      
        public int PlayerId { get; set; }
        public string NickName { get; set; }
        public List<PlayerInstrument> Instruments { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}

