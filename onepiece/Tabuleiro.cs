using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onepiece
{
    // Class for the construction o the map using the 6 different tile images, 36 pictureboxes and the map blueprint requested from the server
    class Tabuleiro
    {
        public void construir(PictureBox[] mapTiles, string mapBlueprint)
        {
            // Replace the 'next line' characters from the string with blanks
            mapBlueprint = mapBlueprint.Replace("\n", "");
            // Split the string at the '\r' characters so that we're left with an array of strings
            string[] mapTilesCode = mapBlueprint.Split('\r');
            char tile;
            for (int i = 1; i < 37; i++)
            {
                // Get the last character of the string so that it corresponds to a char. The char should be 'E','T','P','C','G' or 'F'. Each letter
                // corresponds to one of the 6 different tile images. The if-statement is used to make the jump from three characters "9.E" to four 
                // characters "10.E"
                if (i < 10)
                    tile = mapTilesCode[i][2];
                else
                    tile = mapTilesCode[i][3];

                // A case-statement determines which one of the 6 images should be assigned to each tile based on the blueprint
                switch (tile)
                {

                    case 'E':
                        mapTiles[i - 1].Image = Properties.Resources.cardSkull;
                        break;
                    case 'T':
                        mapTiles[i - 1].Image = Properties.Resources.piratehat;
                        break;
                    case 'P':
                        mapTiles[i - 1].Image = Properties.Resources.cardPistol;
                        break;
                    case 'C':
                        mapTiles[i - 1].Image = Properties.Resources.cardKey;
                        break;
                    case 'G':
                        mapTiles[i - 1].Image = Properties.Resources.cardBottle;
                        break;
                    case 'F':
                        mapTiles[i - 1].Image = Properties.Resources.cardKnife;
                        break;

                }

                // Fits the images within the pictureboxes
                mapTiles[i - 1].SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
