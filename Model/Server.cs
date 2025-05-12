namespace SimpleAPI.Model
{
    public class Server
    {
        public string Ip { get; set; } = string.Empty;
        public int Port { get; set; }
        public string? Hostname { get; set; }
        public string? Version { get; set; }
        public string? Software { get; set; }
        public string? Map { get; set; }
        public string? Gamemode { get; set; }
        public string? Motd { get; set; }
        public int PlayersOnline { get; set; }
        public int PlayersMax { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public List<string> Plugins { get; set; } = new List<string>();
        public List<string> Mods { get; set; } = new List<string>();
        public string? Icon { get; set; }
        public bool IsOnline { get; set; }

        public class Player
        {
            public string? Name { get; set; }
            public string? Uuid { get; set; }
        }
    }
}
