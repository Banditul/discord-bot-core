﻿using Discord.WebSocket;

namespace DiscordBot.Discord.Entities
{
    public class BotConfig
    {
        public string Token { get; set; }

        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
