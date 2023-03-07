using CodeFirstDesign.DTOs.PlayerInstrumentsDto;

namespace CodeFirstDesign.DTOs.PlayersDto
{
    public class GetPlayerDetailResponse
    {
        public string NickName { get; set; }
        public DateTime JoinedDate { get; set; }
        public List<GetPlayerInstrumentResponse> PlayerInstruments { get; set; }

    }
}
