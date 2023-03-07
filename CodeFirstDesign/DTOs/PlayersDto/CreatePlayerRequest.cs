using CodeFirstDesign.DTOs.PlayerInstruments;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDesign.DTOs.Players
{
    public class CreatePlayerRequest
    {
        [Required]
        public string NickName { get; set; }
        [Required]

        public List<CreatePlayerInstrumentRequest>
        PlayerInstruments
        { get; set; }
    }
}
