using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using totk.Content.Items.Materials;

namespace totk.Content.Tiles
{
    // Simple 3x3 tile that can be placed on a wall
    public class Construct : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.addTile(Type);

            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Steward Construct");
            AddMapEntry(new Color(120, 85, 60), name);
            DustType = 7;
        }
    }
}