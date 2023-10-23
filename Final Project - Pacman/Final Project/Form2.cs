using Final_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmPacman : Form
    {       
        int pacmanDirection = 0;
        int pacmanLeft = 0;
        int pacmanRight = 0;
        int pacmanTop = 0;
        int pacmanBottom = 0;
        int pacmanWidth = 0;
        int pacmanHeight = 0;
        int Lives = 3;
        int dotsEaten = 0;
        int level = 1;
        int points = 0;

        int BlueGhostDirection = 0;
        int BlueGhostLeft = 0;
        int BlueGhostRight = 0;
        int BlueGhostTop = 0;
        int BlueGhostBottom = 0;
        int BlueGhostWidth = 0;
        int BlueGhostHeight = 0;
        const int MOVE_BLUEGHOST_AMOUNT = 4;

        int RedGhostDirection = 0;
        int RedGhostLeft = 0;
        int RedGhostRight = 0;
        int RedGhostTop = 0;
        int RedGhostBottom = 0;
        int RedGhostWidth = 0;
        int RedGhostHeight = 0;
        const int MOVE_REDGHOST_AMOUNT = 4;

        int OrangeGhostDirection = 0;
        int OrangeGhostLeft = 0;
        int OrangeGhostRight = 0;
        int OrangeGhostTop = 0;
        int OrangeGhostBottom = 0;
        int OrangeGhostWidth = 0;
        int OrangeGhostHeight = 0;
        const int MOVE_ORANGEGHOST_AMOUNT = 4;

        int PinkGhostDirection = 0;
        int PinkGhostLeft = 0;
        int PinkGhostRight = 0;
        int PinkGhostTop = 0;
        int PinkGhostBottom = 0;
        int PinkGhostWidth = 0;
        int PinkGhostHeight = 0;
        const int MOVE_PINKGHOST_MOVE = 4;

        bool isOpen = true;


        // CHANGE THIS ANYTIME I ADD A DOT
        const int MAX_DOTS = 131;

        int[] dotLefts   = new int[MAX_DOTS];
        int[] dotRights  = new int[MAX_DOTS];
        int[] dotTops    = new int[MAX_DOTS];
        int[] dotBottoms = new int[MAX_DOTS];
        int[] dotHeights = new int[MAX_DOTS];
        int[] dotWidths  = new int[MAX_DOTS];

        PictureBox[] dotPictures = new PictureBox[MAX_DOTS];

        // CHANGE THIS ANYTIME I ADD A WALL
        const int MAX_WALLS = 46;

        int[] wallLefts = new int[MAX_WALLS];
        int[] wallRights = new int[MAX_WALLS];
        int[] wallTops = new int[MAX_WALLS];
        int[] wallBottoms = new int[MAX_WALLS];
        int[] wallHeights = new int[MAX_WALLS];
        int[] wallWidths = new int[MAX_WALLS];

        bool[] hittingWalls = new bool[MAX_WALLS];

        PictureBox[] wallPictures = new PictureBox[MAX_WALLS];


        // CHANGE THIS ANYTIME I ADD A TELEPORT
        const int MAX_TELEPORTS = 2;

        int[] teleportLefts = new int[MAX_TELEPORTS];
        int[] teleportRights = new int[MAX_TELEPORTS];
        int[] teleportTops = new int[MAX_TELEPORTS];
        int[] teleportBottoms = new int[MAX_TELEPORTS];
        int[] teleportHeights = new int[MAX_TELEPORTS];
        int[] teleportWidths = new int[MAX_TELEPORTS];

        bool[] hittingTeleports = new bool[MAX_WALLS];

        PictureBox[] teleportPictures = new PictureBox[MAX_TELEPORTS];


        const int KEY_ESCAPE = 27;
        const int KEY_UP = 38;
        const int KEY_DOWN = 40;
        const int KEY_LEFT = 37;
        const int KEY_RIGHT = 39;
        const int MOVE_LEFT = 1;
        const int MOVE_RIGHT = 2;
        const int MOVE_UP = 3;
        const int MOVE_DOWN = 4;
        const int MOVE_PACMAN_AMOUNT = 3;
        Random random = new Random();

        public frmPacman()
        {
            InitializeComponent();
        }

        private void frmPacman_Load(object sender, EventArgs e)
        {

            // CHANGE THIS ANYTIME I ADD A DOT
            dotPictures[0] = picDot1;
            dotPictures[1] = picDot2;
            dotPictures[2] = picDot3;
            dotPictures[3] = picDot4;
            dotPictures[4] = picDot5;
            dotPictures[5] = picDot6;
            dotPictures[6] = picDot7;
            dotPictures[7] = picDot8;
            dotPictures[8] = picDot9;
            dotPictures[9] = picDot10;
            dotPictures[10] = picDot11;
            dotPictures[11] = picDot12;
            dotPictures[12] = picDot13;
            dotPictures[13] = picDot14;
            dotPictures[14] = picDot15;
            dotPictures[15] = picDot16;
            dotPictures[16] = picDot17;
            dotPictures[17] = picDot18;
            dotPictures[18] = picDot19;
            dotPictures[19] = picDot20;
            dotPictures[20] = picDot21;
            dotPictures[21] = picDot22;
            dotPictures[22] = picDot23;
            dotPictures[23] = picDot24;
            dotPictures[24] = picDot25;
            dotPictures[25] = picDot26;
            dotPictures[26] = picDot27;
            dotPictures[27] = picDot28;
            dotPictures[28] = picDot29;
            dotPictures[29] = picDot30;
            dotPictures[30] = picDot31;
            dotPictures[31] = picDot32;
            dotPictures[32] = picDot33;
            dotPictures[33] = picDot34;
            dotPictures[34] = picDot35;
            dotPictures[35] = picDot36;
            dotPictures[36] = picDot37;
            dotPictures[37] = picDot38;
            dotPictures[38] = picDot39;
            dotPictures[39] = picDot40;
            dotPictures[40] = picDot41;
            dotPictures[41] = picDot42;
            dotPictures[42] = picDot43;
            dotPictures[43] = picDot44;
            dotPictures[44] = picDot45;
            dotPictures[45] = picDot46;
            dotPictures[46] = picDot47;
            dotPictures[47] = picDot48;
            dotPictures[48] = picDot49;
            dotPictures[49] = picDot50;
            dotPictures[50] = picDot51;
            dotPictures[51] = picDot52;
            dotPictures[52] = picDot53;
            dotPictures[53] = picDot54;
            dotPictures[54] = picDot55;
            dotPictures[55] = picDot56;
            dotPictures[56] = picDot57;
            dotPictures[57] = picDot58;
            dotPictures[58] = picDot59;
            dotPictures[59] = picDot60;
            dotPictures[60] = picDot61;
            dotPictures[61] = picDot62;
            dotPictures[62] = picDot63;
            dotPictures[63] = picDot64;
            dotPictures[64] = picDot65;
            dotPictures[65] = picDot66;
            dotPictures[66] = picDot67;
            dotPictures[67] = picDot68;
            dotPictures[68] = picDot69;
            dotPictures[69] = picDot70;
            dotPictures[70] = picDot71;
            dotPictures[71] = picDot72;
            dotPictures[72] = picDot73;
            dotPictures[73] = picDot74;
            dotPictures[74] = picDot75;
            dotPictures[75] = picDot76;
            dotPictures[76] = picDot77;
            dotPictures[77] = picDot78;
            dotPictures[78] = picDot79;
            dotPictures[79] = picDot80;
            dotPictures[80] = picDot81;
            dotPictures[81] = picDot82;
            dotPictures[82] = picDot83;
            dotPictures[83] = picDot84;
            dotPictures[84] = picDot85;
            dotPictures[85] = picDot86;
            dotPictures[86] = picDot87;
            dotPictures[87] = picDot88;
            dotPictures[88] = picDot89;
            dotPictures[89] = picDot90;
            dotPictures[90] = picDot91;
            dotPictures[91] = picDot92;
            dotPictures[92] = picDot93;
            dotPictures[93] = picDot94;
            dotPictures[94] = picDot95;
            dotPictures[95] = picDot96;
            dotPictures[96] = picDot97;
            dotPictures[97] = picDot98;
            dotPictures[98] = picDot99;
            dotPictures[99] = picDot100;
            dotPictures[100] = picDot101;
            dotPictures[101] = picDot102;
            dotPictures[102] = picDot103;
            dotPictures[103] = picDot104;
            dotPictures[104] = picDot105;
            dotPictures[105] = picDot106;
            dotPictures[106] = picDot107;
            dotPictures[107] = picDot108;
            dotPictures[108] = picDot109;
            dotPictures[109] = picDot110;
            dotPictures[110] = picDot111;
            dotPictures[111] = picDot112;
            dotPictures[112] = picDot113;
            dotPictures[113] = picDot114;
            dotPictures[114] = picDot115;
            dotPictures[115] = picDot116;
            dotPictures[116] = picDot117;
            dotPictures[117] = picDot118;
            dotPictures[118] = picDot119;
            dotPictures[119] = picDot120;
            dotPictures[120] = picDot121;
            dotPictures[121] = picDot122;
            dotPictures[122] = picDot123;
            dotPictures[123] = picDot124;
            dotPictures[124] = picDot125;
            dotPictures[125] = picDot126;
            dotPictures[126] = picDot127;
            dotPictures[127] = picDot128;
            dotPictures[128] = picDot129;
            dotPictures[129] = picDot130;
            dotPictures[130] = picDot131;




            // CHANGE THIS ANYTIME I ADD A WALL
            wallPictures[0] = picWall1;
            wallPictures[1] = picWall2;
            wallPictures[2] = picWall3;
            wallPictures[3] = picWall4;
            wallPictures[4] = picWall5;
            wallPictures[5] = picWall6;
            wallPictures[6] = picWall7;
            wallPictures[7] = picWall8;
            wallPictures[8] = picWall9;
            wallPictures[9] = picWall10;
            wallPictures[10] = picWall11;
            wallPictures[11] = picWall12;
            wallPictures[12] = picWall13;
            wallPictures[13] = picWall14;
            wallPictures[14] = picWall15;
            wallPictures[15] = picWall16;
            wallPictures[16] = picWall17;
            wallPictures[17] = picWall18;
            wallPictures[18] = picWall19;
            wallPictures[19] = picWall20;
            wallPictures[20] = picWall21;
            wallPictures[21] = picWall22;
            wallPictures[22] = picWall23;
            wallPictures[23] = picWall24;
            wallPictures[24] = picWall25;
            wallPictures[25] = picWall26;
            wallPictures[26] = picWall27;
            wallPictures[27] = picWall28;
            wallPictures[28] = picWall29;
            wallPictures[29] = picWall30;
            wallPictures[30] = picWall31;
            wallPictures[31] = picWall32;
            wallPictures[32] = picWall33;
            wallPictures[33] = picWall34;
            wallPictures[34] = picWall35;
            wallPictures[35] = picWall36;
            wallPictures[36] = picWall37;
            wallPictures[37] = picWall38;
            wallPictures[38] = picWall39;
            wallPictures[39] = picWall40;
            wallPictures[40] = picWall41;
            wallPictures[41] = picWall42;
            wallPictures[42] = picWall43;
            wallPictures[43] = picWall44;
            wallPictures[44] = picWall45;
            wallPictures[45] = picWall46;


            // CHANGE THIS ANYTIME I ADD A TELEPORT
            teleportPictures[0] = picTeleport1;
            teleportPictures[1] = picTeleport2;

            picPacmanLife1.Visible = true;
            picPacmanLife2.Visible = true;
            picPacmanLife3.Visible = true;
            lblLevel.Text = "Level: " + level;
            lblLives.Text = "Lives: " + Lives;
            lblPoints.Text = "Points: " + points;
            Random random = new Random();
            BlueGhostDirection = random.Next(1, 5);
            RedGhostDirection = random.Next(1, 5);
            OrangeGhostDirection = random.Next(1, 5);
            PinkGhostDirection = random.Next(1, 5);


            for (int i = 0; i < MAX_DOTS; i++)
            {
                dotTops[i] = dotPictures[i].Top;
                dotLefts[i] = dotPictures[i].Left;
                dotWidths[i] = dotPictures[i].Width;
                dotHeights[i] = dotPictures[i].Height;
                dotBottoms[i] = dotTops[i] + dotHeights[i];
                dotRights[i] = dotLefts[i] + dotWidths[i];
            }

            for (int i = 0; i < MAX_WALLS; i++)
            {
                wallTops[i] = wallPictures[i].Top;
                wallLefts[i] = wallPictures[i].Left;
                wallWidths[i] = wallPictures[i].Width;
                wallHeights[i] = wallPictures[i].Height;
                wallBottoms[i] = wallTops[i] + wallHeights[i];
                wallRights[i] = wallLefts[i] + wallWidths[i];
            }

            for (int i = 0; i < MAX_TELEPORTS; i++)
            {
                teleportTops[i] = teleportPictures[i].Top;
                teleportLefts[i] = teleportPictures[i].Left;
                teleportWidths[i] = teleportPictures[i].Width;
                teleportHeights[i] = teleportPictures[i].Height;
                teleportBottoms[i] = teleportTops[i] + teleportHeights[i];
                teleportRights[i] = teleportLefts[i] + teleportWidths[i];
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if (key == KEY_ESCAPE)
            {
                Application.Exit();
            }
            else if (key == KEY_DOWN)
            {
                pacmanDirection = MOVE_DOWN;
            }
            else if (key == KEY_UP)
            {
                pacmanDirection = MOVE_UP;
            }
            else if (key == KEY_LEFT)
            {
                pacmanDirection = MOVE_LEFT;
            }
            else if (key == KEY_RIGHT)
            {
                pacmanDirection = MOVE_RIGHT;
            }
        }

        private void tmrMove_Tick_1(object sender, EventArgs e)
        {
            getPacmanCoordinates();
            movePacmanCoordinates();
            checkPacmanForCollision();
            picPacman.Left = pacmanLeft;
            picPacman.Top = pacmanTop;
        }

        private void checkGhostForCollision()
        {
            
            for (int i = 0; i < MAX_WALLS; i++)
            {
                hittingWalls[i] = false;
                if (((BlueGhostLeft >= wallLefts[i] && BlueGhostLeft <= wallRights[i]) ||
                 (BlueGhostRight >= wallLefts[i] && BlueGhostRight <= wallRights[i])) &&
                ((BlueGhostTop >= wallTops[i] && BlueGhostTop <= wallBottoms[i]) ||
                 (BlueGhostBottom >= wallTops[i] && BlueGhostBottom <= wallBottoms[i])))
                {
                    hittingWalls[i] = true;
                }
                else if (((wallLefts[i] >= BlueGhostLeft && wallLefts[i] <= BlueGhostRight) ||
                          (wallRights[i] >= BlueGhostLeft && wallRights[i] <= BlueGhostRight)) &&
                         ((wallTops[i] >= BlueGhostTop && wallTops[i] <= BlueGhostBottom) ||
                          (wallBottoms[i] >= BlueGhostTop && wallBottoms[i] <= BlueGhostBottom)))
                {
                    hittingWalls[i] = true;
                }
                // react to a wall hit
                if (hittingWalls[i])
                {
                    if (BlueGhostDirection == MOVE_DOWN)
                    {
                        BlueGhostTop = wallTops[i] - BlueGhostHeight - 1;
                        BlueGhostDirection = random.Next(1, 3);
                    }
                    else if (BlueGhostDirection == MOVE_UP)
                    {
                        BlueGhostTop = wallBottoms[i] + 1;
                        BlueGhostDirection = random.Next(1, 3);
                    }
                    else if (BlueGhostDirection == MOVE_LEFT)
                    {
                        BlueGhostLeft = wallRights[i] + 1;
                        BlueGhostDirection = random.Next(3, 5);
                    }
                    else if (BlueGhostDirection == MOVE_RIGHT)
                    {
                        BlueGhostLeft = wallLefts[i] - BlueGhostWidth - 1;
                        BlueGhostDirection = random.Next(3, 5);
                    }
                    BlueGhostBottom = BlueGhostTop + BlueGhostHeight;
                    BlueGhostRight = BlueGhostLeft + BlueGhostWidth;
                    i = MAX_WALLS;
                }
            }

            for (int i = 0; i < MAX_TELEPORTS; i++)
            {
                hittingTeleports[i] = false;
                if (((BlueGhostLeft >= teleportLefts[i] && BlueGhostLeft <= teleportRights[i]) ||
                 (BlueGhostRight >= teleportLefts[i] && BlueGhostRight <= teleportRights[i])) &&
                ((BlueGhostTop >= teleportTops[i] && BlueGhostTop <= teleportBottoms[i]) ||
                 (BlueGhostBottom >= teleportTops[i] && BlueGhostBottom <= teleportBottoms[i])))
                {
                    hittingTeleports[i] = true;
                }
                else if (((teleportLefts[i] >= BlueGhostLeft && teleportLefts[i] <= BlueGhostRight) ||
                          (teleportRights[i] >= BlueGhostLeft && teleportRights[i] <= BlueGhostRight)) &&
                         ((teleportTops[i] >= BlueGhostTop && teleportTops[i] <= BlueGhostBottom) ||
                          (teleportBottoms[i] >= BlueGhostTop && teleportBottoms[i] <= BlueGhostBottom)))
                {
                    hittingTeleports[i] = true;
                }

                // react to a teleport
                if (hittingTeleports[i] == true)
                {
                    if (i == 0)
                    {
                        BlueGhostLeft = teleportRights[1];
                    }
                    else if (i == 1)
                    {
                        BlueGhostLeft = teleportLefts[0] - BlueGhostWidth;
                    }
                    BlueGhostBottom = BlueGhostTop + BlueGhostHeight;
                    BlueGhostRight = BlueGhostLeft + BlueGhostWidth;
                    i = MAX_TELEPORTS;
                }
            }
        }

        private void getPacmanCoordinates()
        {
            pacmanTop = picPacman.Top;
            pacmanLeft = picPacman.Left;
            pacmanWidth = picPacman.Width;
            pacmanHeight = picPacman.Height;
            pacmanBottom = pacmanTop + pacmanHeight;
            pacmanRight = pacmanLeft + pacmanWidth;
            
        }

        private void movePacmanCoordinates()
        {
            if (pacmanDirection == MOVE_LEFT)
            {
                pacmanLeft = pacmanLeft - MOVE_PACMAN_AMOUNT;
                lblReadyUp.Visible = false;
            }
            else if (pacmanDirection == MOVE_RIGHT)
            {
                pacmanLeft = pacmanLeft + MOVE_PACMAN_AMOUNT;
                lblReadyUp.Visible = false;
            }
            else if (pacmanDirection == MOVE_UP)
            {
                pacmanTop = pacmanTop - MOVE_PACMAN_AMOUNT;
                lblReadyUp.Visible = false;
            }
            else if (pacmanDirection == MOVE_DOWN)
            {
                pacmanTop = pacmanTop + MOVE_PACMAN_AMOUNT;
                lblReadyUp.Visible = false;

            }
            pacmanBottom = pacmanTop + pacmanHeight;
            pacmanRight = pacmanLeft + pacmanWidth;
        }

        private void checkPacmanForCollision()
        {
            for (int i = 0; i < MAX_DOTS; i++)
            {

                if (dotPictures[i].Visible == true)
                {
                    if (((pacmanLeft >= dotLefts[i] && pacmanLeft <= dotRights[i]) ||
                     (pacmanRight >= dotLefts[i] && pacmanRight <= dotRights[i])) &&
                    ((pacmanTop >= dotTops[i] && pacmanTop <= dotBottoms[i]) ||
                     (pacmanBottom >= dotTops[i] && pacmanBottom <= dotBottoms[i])))
                    {
                        dotPictures[i].Visible = false;
                        dotsEaten++;
                        points = points + 10;
                        lblPoints.Text = "Points: " + points; 
                    }
                    else if (((dotLefts[i] >= pacmanLeft && dotLefts[i] <= pacmanRight) ||
                              (dotRights[i] >= pacmanLeft && dotRights[i] <= pacmanRight)) &&
                             ((dotTops[i] >= pacmanTop && dotTops[i] <= pacmanBottom) ||
                              (dotBottoms[i] >= pacmanTop && dotBottoms[i] <= pacmanBottom)))
                    {
                        dotPictures[i].Visible = false;
                        dotsEaten++;
                        points = points + 10;
                        lblPoints.Text = "Points: " + points;
                    }
                }
            }
            if (dotsEaten == MAX_DOTS)
            {
                level++;
                dotsEaten = 0;
                lblReadyUp.Visible = true;
                pacmanLeft = 430;
                pacmanTop = 438;
                picBlueGhost.Location = new Point(413, 215);
                picRedGhost.Location = new Point(421, 177);
                picOrangeGhost.Location = new Point(391, 211);
                picPinkGhost.Location = new Point(437, 211);
                if (Lives == 3)
                {
                    picPacmanLife3.Visible = true;
                    picPacmanLife2.Visible = true;
                    picPacmanLife1.Visible = true;
                    Lives = 3;
                }
                else if (Lives == 2)
                {
                    picPacmanLife3.Visible = false;
                    picPacmanLife2.Visible = true;
                    picPacmanLife1.Visible = true;
                    Lives = 2;
                }
                else if (Lives == 1)
                {
                    picPacmanLife3.Visible = false;
                    picPacmanLife2.Visible = false;
                    picPacmanLife1.Visible = true;
                    Lives = 1;
                }
                lblPoints.Text = "Points: " + points;
                lblLevel.Text = "Level: " + level;
                lblLives.Text = "Lives: " + Lives;
                tmrBlueGhostMove.Enabled = false;
                tmrMove.Enabled = false;
                tmrRedGhostMove.Enabled = false;
                tmrOrangeGhostMove.Enabled = false;
                tmrPinkGhostMove.Enabled = false;
                MessageBox.Show("You Win!");
                if (level == 2)
                {
                    for (int x = 0; x < dotPictures.Length; x++)
                    {
                        dotPictures[x].Visible = true;
                    }                   
                    picRedGhost.Visible = true;
                    MessageBox.Show("Level 2");
                    tmrBlueGhostMove.Enabled = true;
                    tmrMove.Enabled = true;
                    tmrRedGhostMove.Enabled = true;
                }
                if (level == 3)
                {
                    for (int x = 0; x < dotPictures.Length; x++)
                    {
                        dotPictures[x].Visible = true;
                    }                   
                    picOrangeGhost.Visible = true;
                    MessageBox.Show("Level 3");
                    tmrBlueGhostMove.Enabled = true;
                    tmrMove.Enabled = true;
                    tmrRedGhostMove.Enabled = true;
                    tmrOrangeGhostMove.Enabled = true;
                }
                if (level == 4)
                {                    
                    for (int x = 0; x < dotPictures.Length; x++)
                    {
                        dotPictures[x].Visible = true;
                    }                                     
                    picPinkGhost.Visible = true;
                    MessageBox.Show("Level 4");
                    tmrBlueGhostMove.Enabled = true;
                    tmrMove.Enabled = true;
                    tmrRedGhostMove.Enabled = true;
                    tmrOrangeGhostMove.Enabled = true;
                    tmrPinkGhostMove.Enabled = true;
                }               
                if (level == 5)
                {
                    tmrBlueGhostMove.Enabled = false;
                    tmrMove.Enabled = false;
                    tmrRedGhostMove.Enabled = false;
                    tmrOrangeGhostMove.Enabled = false;
                    tmrPinkGhostMove.Enabled = false;
                    MessageBox.Show("You Finished The Game!");
                    MessageBox.Show("I Hope You Enjoyed The Game!");
                    Application.Exit();
                }
            }

            for (int i = 0; i < MAX_WALLS; i++)
            {
                hittingWalls[i] = false;
                if (((pacmanLeft >= wallLefts[i] && pacmanLeft <= wallRights[i]) ||
                 (pacmanRight >= wallLefts[i] && pacmanRight <= wallRights[i])) &&
                ((pacmanTop >= wallTops[i] && pacmanTop <= wallBottoms[i]) ||
                 (pacmanBottom >= wallTops[i] && pacmanBottom <= wallBottoms[i])))
                {
                    hittingWalls[i] = true;
                }
                else if (((wallLefts[i] >= pacmanLeft && wallLefts[i] <= pacmanRight) ||
                          (wallRights[i] >= pacmanLeft && wallRights[i] <= pacmanRight)) &&
                         ((wallTops[i] >= pacmanTop && wallTops[i] <= pacmanBottom) ||
                          (wallBottoms[i] >= pacmanTop && wallBottoms[i] <= pacmanBottom)))
                {
                    hittingWalls[i] = true;
                }
                // react to a wall hit
                if (hittingWalls[i])
                {
                    if (pacmanDirection == MOVE_DOWN)
                    {
                        pacmanTop = wallTops[i] - pacmanHeight - 1;
                    }
                    else if (pacmanDirection == MOVE_UP)
                    {
                        pacmanTop = wallBottoms[i] + 1;
                    }
                    else if (pacmanDirection == MOVE_LEFT)
                    {
                        pacmanLeft = wallRights[i] + 1;
                    }
                    else if (pacmanDirection == MOVE_RIGHT)
                    {
                        pacmanLeft = wallLefts[i] - pacmanWidth - 1;
                    }
                    pacmanBottom = pacmanTop + pacmanHeight;
                    pacmanRight = pacmanLeft + pacmanWidth;
                    i = MAX_WALLS;
                }                
            }

            for (int i = 0; i < MAX_TELEPORTS; i++)
            {
                hittingTeleports[i] = false;
                if (((pacmanLeft >= teleportLefts[i] && pacmanLeft <= teleportRights[i]) ||
                 (pacmanRight >= teleportLefts[i] && pacmanRight <= teleportRights[i])) &&
                ((pacmanTop >= teleportTops[i] && pacmanTop <= teleportBottoms[i]) ||
                 (pacmanBottom >= teleportTops[i] && pacmanBottom <= teleportBottoms[i])))
                {
                    hittingTeleports[i] = true;
                }
                else if (((teleportLefts[i] >= pacmanLeft && teleportLefts[i] <= pacmanRight) ||
                          (teleportRights[i] >= pacmanLeft && teleportRights[i] <= pacmanRight)) &&
                         ((teleportTops[i] >= pacmanTop && teleportTops[i] <= pacmanBottom) ||
                          (teleportBottoms[i] >= pacmanTop && teleportBottoms[i] <= pacmanBottom)))
                {
                    hittingTeleports[i] = true;
                }

                // react to a teleport
                if (hittingTeleports[i] == true)
                {
                    if (i == 0)
                    {
                        pacmanLeft = teleportRights[1];
                    }
                    else if (i == 1)
                    {
                        pacmanLeft = teleportLefts[0] - pacmanWidth;
                    }
                    pacmanBottom = pacmanTop + pacmanHeight;
                    pacmanRight = pacmanLeft + pacmanWidth;
                    i = MAX_TELEPORTS;
                }
            }
        }

        private void tmrBlurGhostMove_Tick(object sender, EventArgs e)
        {
            getBlueGhostCoordinates();
            moveBlueGhostCoordinates();
            checkGhostForCollision();
            checkforBlueGhostCollision();
            picBlueGhost.Left = BlueGhostLeft;
            picBlueGhost.Top = BlueGhostTop;
        }

        private void checkforBlueGhostCollision()
        {
            for (int i = 0; i < BlueGhostDirection; i++)
            {
                bool hittingBlueGhost = false;
                if (((pacmanLeft >= BlueGhostLeft && pacmanLeft <= BlueGhostRight) ||
                 (pacmanRight >= BlueGhostLeft && pacmanRight <= BlueGhostRight)) &&
                ((pacmanTop >= BlueGhostTop && pacmanTop <= BlueGhostBottom) ||
                 (pacmanBottom >= BlueGhostTop && pacmanBottom <= BlueGhostBottom)))
                {
                    hittingBlueGhost = true;
                }
                else if (((BlueGhostLeft >= pacmanLeft && BlueGhostLeft <= pacmanRight) ||
                          (BlueGhostRight >= pacmanLeft && BlueGhostRight <= pacmanRight)) &&
                         ((BlueGhostTop >= pacmanTop && BlueGhostTop <= pacmanBottom) ||
                          (BlueGhostBottom >= pacmanTop && BlueGhostBottom <= pacmanBottom)))
                {
                    hittingBlueGhost = true;
                }
                // react to a wall hit

                if (hittingBlueGhost)
                {
                    if (level == 1 || level == 2 || level == 3 || level == 4)
                    {
                        dotsEaten = 0;
                        if (Lives > 0)
                        {
                            for (int x = 0; x < dotPictures.Length; x++)
                            {
                                dotPictures[x].Visible = true;
                            }
                            picPacman.Location = new Point(430, 438);
                            picBlueGhost.Location = new Point(413, 215);
                            Lives--;
                            points = 0;
                            lblPoints.Text = "Points: " + points;
                            lblLevel.Text = "Level: " + level;
                            lblLives.Text = "Lives: " + Lives;
                            if (Lives > 1)
                            {
                                MessageBox.Show("You have " + Lives + " Lives Left!");
                                picPacmanLife3.Visible = false;
                            }
                            else if (Lives == 1)
                            {
                                MessageBox.Show("You have " + Lives + " Life Left!");
                                picPacmanLife2.Visible = false;
                            }
                            else if (Lives == 0)
                            {
                                picPacmanLife1.Visible = false;
                                MessageBox.Show("Game Over!");                                
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private void moveBlueGhostCoordinates()
        {
            if (BlueGhostDirection == MOVE_LEFT)
            {
                BlueGhostLeft = BlueGhostLeft - MOVE_BLUEGHOST_AMOUNT;
                picBlueGhost.Image = Final_Project.Properties.Resources.Blue_Ghost_Left_2__1_;
            }
            else if (BlueGhostDirection == MOVE_RIGHT)
            {
                BlueGhostLeft = BlueGhostLeft + MOVE_BLUEGHOST_AMOUNT;
                picBlueGhost.Image = Final_Project.Properties.Resources.Blue_Ghost_Left_2__2_;
            }
            else if (BlueGhostDirection == MOVE_UP)
            {
                BlueGhostTop = BlueGhostTop - MOVE_BLUEGHOST_AMOUNT;
                picBlueGhost.Image = Final_Project.Properties.Resources.Blue_Ghost_Up;
            }
            else if (BlueGhostDirection == MOVE_DOWN)
            {
                BlueGhostTop = BlueGhostTop + MOVE_BLUEGHOST_AMOUNT;
                picBlueGhost.Image = Final_Project.Properties.Resources.Blue_Ghost_Down;
            }
            BlueGhostBottom = BlueGhostTop + BlueGhostHeight;
            BlueGhostRight = BlueGhostLeft + BlueGhostWidth;
        }

        private void getBlueGhostCoordinates()
        {
            BlueGhostTop = picBlueGhost.Top;
            BlueGhostLeft = picBlueGhost.Left;
            BlueGhostWidth = picBlueGhost.Width;
            BlueGhostHeight = picBlueGhost.Height;
            BlueGhostBottom = BlueGhostTop + BlueGhostHeight;
            BlueGhostRight = BlueGhostLeft + BlueGhostWidth;
        }

        private void tmrRedGhostMove_Tick(object sender, EventArgs e)
        {
            getRedGhostCoordinates();
            moveRedGhostCoordinates();
            checkRedGhostForCollision();
            checkforRedGhostCollision();
            picRedGhost.Left = RedGhostLeft;
            picRedGhost.Top = RedGhostTop;
        }

        private void checkforRedGhostCollision()
        {
            for (int i = 0; i < RedGhostDirection; i++)
            {
                bool hittingRedGhost = false;
                if (((pacmanLeft >= RedGhostLeft && pacmanLeft <= RedGhostRight) ||
                 (pacmanRight >= RedGhostLeft && pacmanRight <= RedGhostRight)) &&
                ((pacmanTop >= RedGhostTop && pacmanTop <= RedGhostBottom) ||
                 (pacmanBottom >= RedGhostTop && pacmanBottom <= RedGhostBottom)))
                {
                    hittingRedGhost = true;
                }
                else if (((RedGhostLeft >= pacmanLeft && RedGhostLeft <= pacmanRight) ||
                          (RedGhostRight >= pacmanLeft && RedGhostRight <= pacmanRight)) &&
                         ((RedGhostTop >= pacmanTop && RedGhostTop <= pacmanBottom) ||
                          (RedGhostBottom >= pacmanTop && RedGhostBottom <= pacmanBottom)))
                {
                    hittingRedGhost = true;
                }
                // react to a wall hit

                if (hittingRedGhost)
                {
                    if (level == 2 || level == 3 || level == 4)
                    {
                        dotsEaten = 0;
                        if (Lives > 0)
                        {
                            for (int x = 0; x < dotPictures.Length; x++)
                            {
                                dotPictures[x].Visible = true;
                            }
                            picPacman.Location = new Point(430, 438);
                            picRedGhost.Location = new Point(413, 215);
                            Lives--;
                            points = 0;
                            lblPoints.Text = "Points: " + points;
                            lblLevel.Text = "Level: " + level;
                            lblLives.Text = "Lives: " + Lives;
                            if (Lives > 1)
                            {
                                MessageBox.Show("You have " + Lives + " Lives Left!");
                                picPacmanLife3.Visible = false;
                            }
                            else if (Lives == 1)
                            {
                                MessageBox.Show("You have " + Lives + " Life Left!");
                                picPacmanLife2.Visible = false;
                            }
                            else if (Lives == 0)
                            {
                                picPacmanLife1.Visible = false;
                                MessageBox.Show("Game Over!");                                
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private void checkRedGhostForCollision()
        {
            for (int i = 0; i < MAX_WALLS; i++)
            {
                hittingWalls[i] = false;
                if (((RedGhostLeft >= wallLefts[i] && RedGhostLeft <= wallRights[i]) ||
                 (RedGhostRight >= wallLefts[i] && RedGhostRight <= wallRights[i])) &&
                ((RedGhostTop >= wallTops[i] && RedGhostTop <= wallBottoms[i]) ||
                 (RedGhostBottom >= wallTops[i] && RedGhostBottom <= wallBottoms[i])))
                {
                    hittingWalls[i] = true;
                }
                else if (((wallLefts[i] >= RedGhostLeft && wallLefts[i] <= RedGhostRight) ||
                          (wallRights[i] >= RedGhostLeft && wallRights[i] <= RedGhostRight)) &&
                         ((wallTops[i] >= RedGhostTop && wallTops[i] <= RedGhostBottom) ||
                          (wallBottoms[i] >= RedGhostTop && wallBottoms[i] <= RedGhostBottom)))
                {
                    hittingWalls[i] = true;
                }
                // react to a wall hit
                if (hittingWalls[i])
                {
                    if (RedGhostDirection == MOVE_DOWN)
                    {
                        RedGhostTop = wallTops[i] - RedGhostHeight - 1;
                        RedGhostDirection = random.Next(1, 3);
                    }
                    else if (RedGhostDirection == MOVE_UP)
                    {
                        RedGhostTop = wallBottoms[i] + 1;
                        RedGhostDirection = random.Next(1, 3);
                    }
                    else if (RedGhostDirection == MOVE_LEFT)
                    {
                        RedGhostLeft = wallRights[i] + 1;
                        RedGhostDirection = random.Next(3, 5);
                    }
                    else if (RedGhostDirection == MOVE_RIGHT)
                    {
                        RedGhostLeft = wallLefts[i] - RedGhostWidth - 1;
                        RedGhostDirection = random.Next(3, 5);
                    }
                    RedGhostBottom = RedGhostTop + RedGhostHeight;
                    RedGhostRight = RedGhostLeft + RedGhostWidth;
                    i = MAX_WALLS;
                }
            }

            for (int i = 0; i < MAX_TELEPORTS; i++)
            {
                hittingTeleports[i] = false;
                if (((RedGhostLeft >= teleportLefts[i] && RedGhostLeft <= teleportRights[i]) ||
                 (RedGhostRight >= teleportLefts[i] && RedGhostRight <= teleportRights[i])) &&
                ((RedGhostTop >= teleportTops[i] && RedGhostTop <= teleportBottoms[i]) ||
                 (RedGhostBottom >= teleportTops[i] && RedGhostBottom <= teleportBottoms[i])))
                {
                    hittingTeleports[i] = true;
                }
                else if (((teleportLefts[i] >= RedGhostLeft && teleportLefts[i] <= RedGhostRight) ||
                          (teleportRights[i] >= RedGhostLeft && teleportRights[i] <= RedGhostRight)) &&
                         ((teleportTops[i] >= RedGhostTop && teleportTops[i] <= RedGhostBottom) ||
                          (teleportBottoms[i] >= RedGhostTop && teleportBottoms[i] <= RedGhostBottom)))
                {
                    hittingTeleports[i] = true;
                }

                // react to a teleport
                if (hittingTeleports[i] == true)
                {
                    if (i == 0)
                    {
                        RedGhostLeft = teleportRights[1];
                    }
                    else if (i == 1)
                    {
                        RedGhostLeft = teleportLefts[0] - RedGhostWidth;
                    }
                    RedGhostBottom = RedGhostTop + RedGhostHeight;
                    RedGhostRight = RedGhostLeft + RedGhostWidth;
                    i = MAX_TELEPORTS;
                }
            }
        }

        private void moveRedGhostCoordinates()
        {
            if (RedGhostDirection == MOVE_LEFT)
            {
                RedGhostLeft = RedGhostLeft - MOVE_REDGHOST_AMOUNT;
                picRedGhost.Image = Final_Project.Properties.Resources.pacman_ghost_Red;
            }
            else if (RedGhostDirection == MOVE_RIGHT)
            {
                RedGhostLeft = RedGhostLeft + MOVE_REDGHOST_AMOUNT;
                picRedGhost.Image = Final_Project.Properties.Resources.Red_Ghost_Right;
            }
            else if (RedGhostDirection == MOVE_UP)
            {
                RedGhostTop = RedGhostTop - MOVE_REDGHOST_AMOUNT;
                picRedGhost.Image = Final_Project.Properties.Resources.Red_Ghost_Up;
            }
            else if (RedGhostDirection == MOVE_DOWN)
            {
                RedGhostTop = RedGhostTop + MOVE_REDGHOST_AMOUNT;
                picRedGhost.Image = Final_Project.Properties.Resources.Red_Ghost_Down;

            }
            RedGhostBottom = RedGhostTop + RedGhostHeight;
            RedGhostRight = RedGhostLeft + RedGhostWidth;
        }

        private void getRedGhostCoordinates()
        {
            RedGhostTop = picRedGhost.Top;
            RedGhostLeft = picRedGhost.Left;
            RedGhostWidth = picRedGhost.Width;
            RedGhostHeight = picRedGhost.Height;
            RedGhostBottom = RedGhostTop + RedGhostHeight;
            RedGhostRight = RedGhostLeft + RedGhostWidth;
        }

        private void tmrAnimate_Tick(object sender, EventArgs e)
        {
            if (isOpen == true)
            {
                isOpen = false;
                if (pacmanDirection == MOVE_LEFT)
                {
                    picPacman.Image = Final_Project.Properties.Resources.pacman_Left;
                }
                else if (pacmanDirection == MOVE_RIGHT)
                {
                    picPacman.Image = Properties.Resources.pacman;
                }
                else if (pacmanDirection == MOVE_UP)
                {
                    picPacman.Image = Properties.Resources.Pacman_up;
                }
                else if (pacmanDirection == MOVE_DOWN)
                {
                    picPacman.Image = Properties.Resources.Pacman_down;
                }
            }
            else if (isOpen == false)
            {
                isOpen = true;
                if (pacmanDirection == MOVE_LEFT)
                {
                    picPacman.Image = Final_Project.Properties.Resources.Pacman_closed_Mouth_Left;
                }
                else if (pacmanDirection == MOVE_RIGHT)
                {
                    picPacman.Image = Properties.Resources.Pacman_closed_Mouth_Right;
                }
                else if (pacmanDirection == MOVE_UP)
                {
                    picPacman.Image = Properties.Resources.Pacman_closed_Mouth_Up;
                }
                else if (pacmanDirection == MOVE_DOWN)
                {
                    picPacman.Image = Properties.Resources.Pacman_closed_Mouth_Down_2;
                }
            }
        }

        private void tmrOrangeGhostMove_Tick(object sender, EventArgs e)
        {
            getOrangeGhostCoordinates();
            moveOrangeGhostCoordinates();
            checkOrangeGhostForCollision();
            checkforOrangeGhostCollision();
            picOrangeGhost.Left = OrangeGhostLeft;
            picOrangeGhost.Top = OrangeGhostTop;
        }

        private void checkOrangeGhostForCollision()
        {
            for (int i = 0; i < MAX_WALLS; i++)
            {
                hittingWalls[i] = false;
                if (((OrangeGhostLeft >= wallLefts[i] && OrangeGhostLeft <= wallRights[i]) ||
                 (OrangeGhostRight >= wallLefts[i] && OrangeGhostRight <= wallRights[i])) &&
                ((OrangeGhostTop >= wallTops[i] && OrangeGhostTop <= wallBottoms[i]) ||
                 (OrangeGhostBottom >= wallTops[i] && OrangeGhostBottom <= wallBottoms[i])))
                {
                    hittingWalls[i] = true;
                }
                else if (((wallLefts[i] >= OrangeGhostLeft && wallLefts[i] <= OrangeGhostRight) ||
                          (wallRights[i] >= OrangeGhostLeft && wallRights[i] <= OrangeGhostRight)) &&
                         ((wallTops[i] >= OrangeGhostTop && wallTops[i] <= OrangeGhostBottom) ||
                          (wallBottoms[i] >= OrangeGhostTop && wallBottoms[i] <= OrangeGhostBottom)))
                {
                    hittingWalls[i] = true;
                }
                // react to a wall hit
                if (hittingWalls[i])
                {
                    if (OrangeGhostDirection == MOVE_DOWN)
                    {
                        OrangeGhostTop = wallTops[i] - OrangeGhostHeight - 1;
                        OrangeGhostDirection = random.Next(1, 3);
                    }
                    else if (OrangeGhostDirection == MOVE_UP)
                    {
                        OrangeGhostTop = wallBottoms[i] + 1;
                        OrangeGhostDirection = random.Next(1, 3);
                    }
                    else if (OrangeGhostDirection == MOVE_LEFT)
                    {
                        OrangeGhostLeft = wallRights[i] + 1;
                        OrangeGhostDirection = random.Next(3, 5);
                    }
                    else if (OrangeGhostDirection == MOVE_RIGHT)
                    {
                        OrangeGhostLeft = wallLefts[i] - OrangeGhostWidth - 1;
                        OrangeGhostDirection = random.Next(3, 5);
                    }
                    OrangeGhostBottom = OrangeGhostTop + OrangeGhostHeight;
                    OrangeGhostRight = OrangeGhostLeft + OrangeGhostWidth;
                    i = MAX_WALLS;
                }
            }

            for (int i = 0; i < MAX_TELEPORTS; i++)
            {
                hittingTeleports[i] = false;
                if (((OrangeGhostLeft >= teleportLefts[i] && OrangeGhostLeft <= teleportRights[i]) ||
                 (OrangeGhostRight >= teleportLefts[i] && OrangeGhostRight <= teleportRights[i])) &&
                ((OrangeGhostTop >= teleportTops[i] && OrangeGhostTop <= teleportBottoms[i]) ||
                 (OrangeGhostBottom >= teleportTops[i] && OrangeGhostBottom <= teleportBottoms[i])))
                {
                    hittingTeleports[i] = true;
                }
                else if (((teleportLefts[i] >= OrangeGhostLeft && teleportLefts[i] <= OrangeGhostRight) ||
                          (teleportRights[i] >= OrangeGhostLeft && teleportRights[i] <= OrangeGhostRight)) &&
                         ((teleportTops[i] >= OrangeGhostTop && teleportTops[i] <= OrangeGhostBottom) ||
                          (teleportBottoms[i] >= OrangeGhostTop && teleportBottoms[i] <= OrangeGhostBottom)))
                {
                    hittingTeleports[i] = true;
                }

                // react to a teleport
                if (hittingTeleports[i] == true)
                {
                    if (i == 0)
                    {
                        OrangeGhostLeft = teleportRights[1];
                    }
                    else if (i == 1)
                    {
                        OrangeGhostLeft = teleportLefts[0] - OrangeGhostWidth;
                    }
                    OrangeGhostBottom = OrangeGhostTop + OrangeGhostHeight;
                    OrangeGhostRight = OrangeGhostLeft + OrangeGhostWidth;
                    i = MAX_TELEPORTS;
                }
            }
        }

        private void checkforOrangeGhostCollision()
        {
            for (int i = 0; i < OrangeGhostDirection; i++)
            {
                bool hittingOrangeGhost = false;
                if (((pacmanLeft >= OrangeGhostLeft && pacmanLeft <= OrangeGhostRight) ||
                 (pacmanRight >= OrangeGhostLeft && pacmanRight <= OrangeGhostRight)) &&
                ((pacmanTop >= OrangeGhostTop && pacmanTop <= OrangeGhostBottom) ||
                 (pacmanBottom >= OrangeGhostTop && pacmanBottom <= OrangeGhostBottom)))
                {
                    hittingOrangeGhost = true;
                }
                else if (((OrangeGhostLeft >= pacmanLeft && OrangeGhostLeft <= pacmanRight) ||
                          (OrangeGhostRight >= pacmanLeft && OrangeGhostRight <= pacmanRight)) &&
                         ((OrangeGhostTop >= pacmanTop && OrangeGhostTop <= pacmanBottom) ||
                          (OrangeGhostBottom >= pacmanTop && OrangeGhostBottom <= pacmanBottom)))
                {
                    hittingOrangeGhost = true;
                }
                // react to a wall hit

                if (hittingOrangeGhost)
                {
                    if (level == 3 || level == 4)
                    {
                        dotsEaten = 0;
                        if (Lives > 0)
                        {
                            for (int x = 0; x < dotPictures.Length; x++)
                            {
                                dotPictures[x].Visible = true;
                            }
                            picPacman.Location = new Point(430, 438);
                            picOrangeGhost.Location = new Point(413, 215);
                            Lives--;
                            points = 0;
                            lblPoints.Text = "Points: " + points;
                            lblLevel.Text = "Level: " + level;
                            lblLives.Text = "Lives: " + Lives;
                            if (Lives > 1)
                            {
                                MessageBox.Show("You have " + Lives + " Lives Left!");
                                picPacmanLife3.Visible = false;
                            }
                            else if (Lives == 1)
                            {
                                MessageBox.Show("You have " + Lives + " Life Left!");
                                picPacmanLife2.Visible = false;
                            }
                            else if (Lives == 0)
                            {
                                picPacmanLife1.Visible = false;
                                MessageBox.Show("Game Over!");
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private void moveOrangeGhostCoordinates()
        {
            if (OrangeGhostDirection == MOVE_LEFT)
            {
                OrangeGhostLeft = OrangeGhostLeft - MOVE_ORANGEGHOST_AMOUNT;
                picOrangeGhost.Image = Final_Project.Properties.Resources.pacman_ghost_Orange;
            }
            else if (OrangeGhostDirection == MOVE_RIGHT)
            {
                OrangeGhostLeft = OrangeGhostLeft + MOVE_ORANGEGHOST_AMOUNT;
                picOrangeGhost.Image = Final_Project.Properties.Resources.Orange_Ghost_Right;
            }
            else if (OrangeGhostDirection == MOVE_UP)
            {
                OrangeGhostTop = OrangeGhostTop - MOVE_ORANGEGHOST_AMOUNT;
                picOrangeGhost.Image = Final_Project.Properties.Resources.Orange_Ghost_Up;
            }
            else if (OrangeGhostDirection == MOVE_DOWN)
            {
                OrangeGhostTop = OrangeGhostTop + MOVE_ORANGEGHOST_AMOUNT;
                picOrangeGhost.Image = Final_Project.Properties.Resources.Orange_Ghost_Down;
            }
            OrangeGhostBottom = OrangeGhostTop + OrangeGhostHeight;
            OrangeGhostRight = OrangeGhostLeft + OrangeGhostWidth;
        }

        private void getOrangeGhostCoordinates()
        {
            OrangeGhostTop = picOrangeGhost.Top;
            OrangeGhostLeft = picOrangeGhost.Left;
            OrangeGhostWidth = picOrangeGhost.Width;
            OrangeGhostHeight = picOrangeGhost.Height;
            OrangeGhostBottom = OrangeGhostTop + OrangeGhostHeight;
            OrangeGhostRight = OrangeGhostLeft + OrangeGhostWidth;
        }

        private void tmrPinkGhostMove_Tick(object sender, EventArgs e)
        {
            getPinkGhostCoordinates();
            movePinkGhostCoordinates();
            checkPinkGhostForCollision();
            checkforPinkGhostCollision();
            picPinkGhost.Left = PinkGhostLeft;
            picPinkGhost.Top = PinkGhostTop;
        }

        private void checkforPinkGhostCollision()
        {
            for (int i = 0; i < PinkGhostDirection; i++)
            {
                bool hittingPinkGhost = false;
                if (((pacmanLeft >= PinkGhostLeft && pacmanLeft <= PinkGhostRight) ||
                 (pacmanRight >= PinkGhostLeft && pacmanRight <= PinkGhostRight)) &&
                ((pacmanTop >= PinkGhostTop && pacmanTop <= PinkGhostBottom) ||
                 (pacmanBottom >= PinkGhostTop && pacmanBottom <= PinkGhostBottom)))
                {
                    hittingPinkGhost = true;
                }
                else if (((PinkGhostLeft >= pacmanLeft && PinkGhostLeft <= pacmanRight) ||
                          (PinkGhostRight >= pacmanLeft && PinkGhostRight <= pacmanRight)) &&
                         ((PinkGhostTop >= pacmanTop && PinkGhostTop <= pacmanBottom) ||
                          (PinkGhostBottom >= pacmanTop && PinkGhostBottom <= pacmanBottom)))
                {
                    hittingPinkGhost = true;
                }
                // react to a wall hit

                if (hittingPinkGhost)
                {
                    if (level == 4)
                    {
                        dotsEaten = 0;
                        if (Lives > 0)
                        {
                            for (int x = 0; x < dotPictures.Length; x++)
                            {
                                dotPictures[x].Visible = true;
                            }
                            picPacman.Location = new Point(430, 438);
                            picPinkGhost.Location = new Point(413, 215);
                            Lives--;
                            points = 0;
                            lblPoints.Text = "Points: " + points;
                            lblLevel.Text = "Level: " + level;
                            lblLives.Text = "Lives: " + Lives;
                            if (Lives > 1)
                            {
                                MessageBox.Show("You have " + Lives + " Lives Left!");
                                picPacmanLife3.Visible = false;
                            }
                            else if (Lives == 1)
                            {
                                MessageBox.Show("You have " + Lives + " Life Left!");
                                picPacmanLife2.Visible = false;
                            }
                            else if (Lives == 0)
                            {
                                picPacmanLife1.Visible = false;
                                MessageBox.Show("Game Over!");
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private void checkPinkGhostForCollision()
        {
            for (int i = 0; i < MAX_WALLS; i++)
            {
                hittingWalls[i] = false;
                if (((PinkGhostLeft >= wallLefts[i] && PinkGhostLeft <= wallRights[i]) ||
                 (PinkGhostRight >= wallLefts[i] && PinkGhostRight <= wallRights[i])) &&
                ((PinkGhostTop >= wallTops[i] && PinkGhostTop <= wallBottoms[i]) ||
                 (PinkGhostBottom >= wallTops[i] && PinkGhostBottom <= wallBottoms[i])))
                {
                    hittingWalls[i] = true;
                }
                else if (((wallLefts[i] >= PinkGhostLeft && wallLefts[i] <= PinkGhostRight) ||
                          (wallRights[i] >= PinkGhostLeft && wallRights[i] <= PinkGhostRight)) &&
                         ((wallTops[i] >= PinkGhostTop && wallTops[i] <= PinkGhostBottom) ||
                          (wallBottoms[i] >= PinkGhostTop && wallBottoms[i] <= PinkGhostBottom)))
                {
                    hittingWalls[i] = true;
                }
                // react to a wall hit
                if (hittingWalls[i])
                {
                    if (PinkGhostDirection == MOVE_DOWN)
                    {
                        PinkGhostTop = wallTops[i] - PinkGhostHeight - 1;
                        PinkGhostDirection = random.Next(1, 3);
                    }
                    else if (PinkGhostDirection == MOVE_UP)
                    {
                        PinkGhostTop = wallBottoms[i] + 1;
                        PinkGhostDirection = random.Next(1, 3);
                    }
                    else if (PinkGhostDirection == MOVE_LEFT)
                    {
                        PinkGhostLeft = wallRights[i] + 1;
                        PinkGhostDirection = random.Next(3, 5);
                    }
                    else if (PinkGhostDirection == MOVE_RIGHT)
                    {
                        PinkGhostLeft = wallLefts[i] - PinkGhostWidth - 1;
                        PinkGhostDirection = random.Next(3, 5);
                    }
                    PinkGhostBottom = PinkGhostTop + PinkGhostHeight;
                    PinkGhostRight = PinkGhostLeft + PinkGhostWidth;
                    i = MAX_WALLS;
                }
            }

            for (int i = 0; i < MAX_TELEPORTS; i++)
            {
                hittingTeleports[i] = false;
                if (((PinkGhostLeft >= teleportLefts[i] && PinkGhostLeft <= teleportRights[i]) ||
                 (PinkGhostRight >= teleportLefts[i] && PinkGhostRight <= teleportRights[i])) &&
                ((PinkGhostTop >= teleportTops[i] && PinkGhostTop <= teleportBottoms[i]) ||
                 (PinkGhostBottom >= teleportTops[i] && PinkGhostBottom <= teleportBottoms[i])))
                {
                    hittingTeleports[i] = true;
                }
                else if (((teleportLefts[i] >= PinkGhostLeft && teleportLefts[i] <= PinkGhostRight) ||
                          (teleportRights[i] >= PinkGhostLeft && teleportRights[i] <= PinkGhostRight)) &&
                         ((teleportTops[i] >= PinkGhostTop && teleportTops[i] <= PinkGhostBottom) ||
                          (teleportBottoms[i] >= PinkGhostTop && teleportBottoms[i] <= PinkGhostBottom)))
                {
                    hittingTeleports[i] = true;
                }

                // react to a teleport
                if (hittingTeleports[i] == true)
                {
                    if (i == 0)
                    {
                        PinkGhostLeft = teleportRights[1];
                    }
                    else if (i == 1)
                    {
                        PinkGhostLeft = teleportLefts[0] - PinkGhostWidth;
                    }
                    PinkGhostBottom = PinkGhostTop + PinkGhostHeight;
                    PinkGhostRight = PinkGhostLeft + PinkGhostWidth;
                    i = MAX_TELEPORTS;
                }
            }
        }

        private void movePinkGhostCoordinates()
        {
            if (PinkGhostDirection == MOVE_LEFT)
            {
                PinkGhostLeft = PinkGhostLeft - MOVE_PINKGHOST_MOVE;
                picPinkGhost.Image = Final_Project.Properties.Resources.pacman_ghost_Pink1;
            }
            else if (PinkGhostDirection == MOVE_RIGHT)
            {
                PinkGhostLeft = PinkGhostLeft + MOVE_PINKGHOST_MOVE;
                picPinkGhost.Image = Final_Project.Properties.Resources.Pink_Ghost_Right;
            }
            else if (PinkGhostDirection == MOVE_UP)
            {
                PinkGhostTop = PinkGhostTop - MOVE_PINKGHOST_MOVE;
                picPinkGhost.Image = Final_Project.Properties.Resources.Pink_Ghost_Up;
            }
            else if (PinkGhostDirection == MOVE_DOWN)
            {
                PinkGhostTop = PinkGhostTop + MOVE_PINKGHOST_MOVE;
                picPinkGhost.Image = Final_Project.Properties.Resources.Pink_Ghost_Down;
            }
            PinkGhostBottom = PinkGhostTop + PinkGhostHeight;
            PinkGhostRight = PinkGhostLeft + PinkGhostWidth;
        }

        private void getPinkGhostCoordinates()
        {
            PinkGhostTop = picPinkGhost.Top;
            PinkGhostLeft = picPinkGhost.Left;
            PinkGhostWidth = picPinkGhost.Width;
            PinkGhostHeight = picPinkGhost.Height;
            PinkGhostBottom = PinkGhostTop + PinkGhostHeight;
            PinkGhostRight = PinkGhostLeft + PinkGhostWidth;
        }
    }
}
