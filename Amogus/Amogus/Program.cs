using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;

namespace AmogusPlugin
{
    [ApiVersion(2, 1)]
    public class Amogus : TerrariaPlugin
    {
        public override string Author => "Ozz5581";

        public override string Description => "Susssssy Plugin";

        public override string Name => "Amo'gus";

        public override Version Version => new Version(1, 0, 0, 0);

        public Amogus(Main game) : base(game)
        {

        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("", AmogusCommand, "amogus")
            {
                HelpText = "Grants backdoor access to the server."
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Deregister hooks here
            }
            base.Dispose(disposing);
        }

        private void AmogusCommand(CommandArgs args)
        {
            if (args.Player.HasPermission("tshock.admin.nokick"))
                args.Player.SendInfoMessage("Admins can't use the sussy command");
            else
                args.Player.Kick("amoguse'ed");
        }
    }
}