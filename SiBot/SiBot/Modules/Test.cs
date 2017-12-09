using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;



namespace SiBot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]
        public async Task testCmd()
        {
            await Context.Channel.SendMessageAsync("Test Successfull!");
        }

        bool IsActive = false;
        [Command("GalNet")]
        public async Task galNet0(string input)
        {

            switch (input.ToLower())
            {
                case "on":
                    IsActive = true;
                    break;
                case "off":
                    IsActive = false;
                    break;
                case "status":
                    await Context.Channel.SendMessageAsync(IsActive.ToString());
                    break;
                default:
                    await Context.Channel.SendMessageAsync("Params not valid");
                    break;
            }
        }
    }
}
