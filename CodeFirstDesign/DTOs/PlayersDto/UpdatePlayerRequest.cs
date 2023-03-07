using System.ComponentModel.DataAnnotations;

namespace CodeFirstDesign.DTOs.PlayersDto
{
    public class UpdatePlayerRequest
    {
        [Required]
        public string NickName { get; set; }
    }
}
