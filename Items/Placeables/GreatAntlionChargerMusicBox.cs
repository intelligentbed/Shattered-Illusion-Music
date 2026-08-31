#if NEVER //ILL GET RID OF THIS ONCE WE GET SPRITES FOR THE MUSIC BOXES 
using Terraria.ModLoader;

namespace ShatteredMusiMod.Items.Placeables
{
    public class GreatAntlionChargerMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.GreatAntlionChargerMusicBox>();
        public override string MusicFilePath => "Sounds/Music/GreatAntlionCharger";
    }
}
#endif 