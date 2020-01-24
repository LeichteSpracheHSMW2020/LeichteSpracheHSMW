using Discord.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checklist.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping() {
            await ReplyAsync("Pong");
        }

        [Command("checklist")]
        public async Task CreateChecklist([Remainder] string value)
        {
            string[] values = value.Split(' ');
            string text = "";
            foreach (string v in values) {
                text += "||:o:||          " + v + "\n";
            }
            await ReplyAsync(text);
        }
    }
}
