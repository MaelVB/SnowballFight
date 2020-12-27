using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace SnowballFight
{
    class SnowballFightPlayer : ModPlayer
    {
        public List<string> gloveAccessories = new List<string>();

        public override void ResetEffects()
        {
            gloveAccessories = new List<string>();
        }
        
    }
}
