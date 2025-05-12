namespace SimpleAPI.Dto
{
    public class ServerDto
    {
        public bool Online { get; set; }
        public string? Ip { get; set; }
        public int? Port { get; set; }
        public string? Hostname { get; set; }
        public DebugInfo? Debug { get; set; }
        public string? Version { get; set; }
        public ProtocolInfo? Protocol { get; set; }
        public string? Icon { get; set; }
        public string? Software { get; set; }
        public MapInfo? Map { get; set; }
        public string? Gamemode { get; set; }
        public string? Serverid { get; set; }
        public bool? EulaBlocked { get; set; }
        public MotdInfo? Motd { get; set; }
        public PlayersInfo? Players { get; set; }
        public List<PluginInfo>? Plugins { get; set; }
        public List<ModInfo>? Mods { get; set; }
        public InfoSection? Info { get; set; }

        public class DebugInfo
        {
            public bool Ping { get; set; }
            public bool Query { get; set; }
            public bool Bedrock { get; set; }
            public bool Srv { get; set; }
            public bool QueryMismatch { get; set; }
            public bool IpInSrv { get; set; }
            public bool CnameInSrv { get; set; }
            public bool AnimatedMotd { get; set; }
            public bool CacheHit { get; set; }
            public long CacheTime { get; set; }
            public long CacheExpire { get; set; }
            public int ApiVersion { get; set; }
        }

        public class ProtocolInfo
        {
            public int Version { get; set; }
            public string? Name { get; set; }
        }

        public class MapInfo
        {
            public string? Raw { get; set; }
            public string? Clean { get; set; }
            public string? Html { get; set; }
        }

        public class MotdInfo
        {
            public List<string>? Raw { get; set; }
            public List<string>? Clean { get; set; }
            public List<string>? Html { get; set; }
        }

        public class PlayersInfo
        {
            public int Online { get; set; }
            public int Max { get; set; }
            public List<PlayerInfo>? List { get; set; }

            public class PlayerInfo
            {
                public string? Name { get; set; }
                public string? Uuid { get; set; }
            }
        }

        public class PluginInfo
        {
            public string? Name { get; set; }
            public string? Version { get; set; }
        }

        public class ModInfo
        {
            public string? Name { get; set; }
            public string? Version { get; set; }
        }

        public class InfoSection
        {
            public List<string>? Raw { get; set; }
            public List<string>? Clean { get; set; }
            public List<string>? Html { get; set; }
        }
    }
}
