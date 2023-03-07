using CodeFirstDesign.DTOs;
using CodeFirstDesign.DTOs.Players;
using CodeFirstDesign.DTOs.PlayersDto;

namespace CodeFirstDesign.Interfaces
{
    public interface IPlayerService
    {
        Task CreatePlayerAsync(CreatePlayerRequest playerRequest);

        Task<PagedResponse<GetPlayerResponse>> GetPlayersAsync(UrlQueryParameters urlQueryParameters);

        Task<GetPlayerDetailResponse> GetPlayerDetailAsync(int id);

        Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest playerRequest);

        Task<bool> DeletePlayerAsync(int id);
    }
}

