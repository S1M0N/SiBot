using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Reflection;


namespace SiBot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]
        public async Task testCmd()
        {
            await Context.Channel.SendMessageAsync("Test Successfull!");
        }

        private bool _galnetEnabled = false;
        private string[] _allowed = { "on", "off" };

        [Command("GalNet")]
        public async Task galNet0(params string[] _allowed)
        {
            if (_allowed == off)
            {
                if (_galnetEnabled == false)
                {
                    await Context.Channel.SendMessageAsync("GalNet Alerts Are Already OFF");
                }
                else
                {
                    _galnetEnabled = false;
                    await Context.Channel.SendMessageAsync("GalNet Alerts Are Now OFF");
                }
            }
            if (_allowed == on)
            {
                if (_galnetEnabled == false)
                {
                    await Context.Channel.SendMessageAsync("GalNet Alerts Are Already ON");
                }
                else
                {
                    _galnetEnabled = false;
                    await Context.Channel.SendMessageAsync("GalNet Alerts Are Now ON");
                }
            }
        }
    }
}

