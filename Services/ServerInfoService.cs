using System.Net.Http;
using SimpleAPI.Dto;
using SimpleAPI.Model;

namespace SimpleAPI.services
{
    public class ServerInfoService
    {
        private readonly HttpClient _http;

        public ServerInfoService(HttpClient http)
        {
            _http = http;
            _http.DefaultRequestHeaders.Add("User-Agent", "SimpleAPI/1.0");
        }

        public async Task<Server?> GetAsync(string ip)
        {
            var dto = await _http.GetFromJsonAsync<ServerDto>($"https://api.mcsrvstat.us/3/{ip}");
            if (dto == null || !dto.Online) return null;

            var server = new Server
            {
                Ip = dto.Ip ?? string.Empty,
                Port = dto.Port ?? 25565,
                Hostname = dto.Hostname,
                Version = dto.Version,
                Software = dto.Software,
                Map = dto.Map?.Clean,
                Gamemode = dto.Gamemode,
                Motd = string.Join("\n", dto.Motd?.Clean ?? new List<string>()),
                PlayersOnline = dto.Players?.Online ?? 0,
                PlayersMax = dto.Players?.Max ?? 0,
                IsOnline = dto.Online,
                Icon = dto.Icon
            };

            if (dto.Players?.List != null)
            {
                server.Players = dto.Players.List.Select(p => new Server.Player
                {
                    Name = p.Name,
                    Uuid = p.Uuid
                }).ToList();
            }

            if (dto.Plugins != null)
            {
                server.Plugins = dto.Plugins.Select(p => $"{p.Name} v{p.Version}").ToList();
            }

            if (dto.Mods != null)
            {
                server.Mods = dto.Mods.Select(m => $"{m.Name} v{m.Version}").ToList();
            }

            return server;
        }
    }
}
