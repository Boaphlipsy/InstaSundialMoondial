using Terraria;
using Terraria.ModLoader;

namespace InstaSundialMoondial;

public class CooldownSystem : ModSystem
{
    public override void PostUpdateEverything()
    {
        base.PostUpdateEverything();

        var dialActive = Main.fastForwardTimeToDawn || Main.fastForwardTimeToDusk;
        if (dialActive)
        {
            return;
        }

        Main.sundialCooldown = 0;
        Main.moondialCooldown = 0;
    }
}