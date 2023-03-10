using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.VisualStyles;

namespace BrickBreaker
{
    public partial class F_Main : Form
    {
        //フォームの大きさ位置を決定
        const int FIELD_POSITION_X = 10;
        const int FIELD_POSITION_Y = 10;
        const int FIELD_WIDTH = 450;
        const int FIELD_HEIGHT = 450;
        //isBrokenの設定
        const int BLOCK_COLUMN_COUNT = 15;
        const int BLOCK_ROW_COUNT = 8;
        const int BLOCK_WIDTH = FIELD_WIDTH / BLOCK_COLUMN_COUNT;
        const int BLOCK_HEIGHT = 10;
        const int a = 3;


        //各ブロックに対する崩れたか否かのブール
        //下の[,]のカンマは二次元配列であることを示している
        bool[,] isBroken = new bool[BLOCK_ROW_COUNT, BLOCK_COLUMN_COUNT];
        public F_Main()
        {
            InitializeComponent();
            BackColor= Color.Black;
            DoubleBuffered= true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawField(e.Graphics);

            DrawBlocks(e.Graphics);

            base.OnPaint(e);
        }

        private void DrawField(Graphics g)
        {
            Rectangle rect = new Rectangle(FIELD_POSITION_X, FIELD_POSITION_Y, FIELD_WIDTH, FIELD_HEIGHT);
            g.DrawRectangle(new Pen(Color.White), rect);
        }


        private void SpaceOnClick(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode; 
            if (key == Keys.Space) 
            {
                GameStart();
            }
        }
        private void GameStart()
        {
            ClearAllBroken();
        }

        private void ClearAllBroken()
        {
            for (int y = 0; y < BLOCK_ROW_COUNT; y++)
            {
                for (int x = 0; x < BLOCK_COLUMN_COUNT; x++)
                {
                    isBroken[y, x] = false;
                }
            }
        }

        private void DrawBlocks(Graphics g)
        {
            for (int y = 0; y < BLOCK_ROW_COUNT; y++)
            {
                Color color = Color.Empty;
                switch (y)
                {
                    case 0:
                        color = Color.Red;
                        break;
                    case 1:
                        color = Color.Red;
                        break;
                    case 2:
                        color = Color.Orange;
                        break;
                    case 3:
                        color = Color.Orange;
                        break;
                    case 4:
                        color = Color.Green;
                        break;
                    case 5:
                        color = Color.Green;
                        break;
                    case 6:
                        color = Color.Yellow;
                        break;
                    case 7:
                        color = Color.Yellow;
                        break;
                }
                for (int x = 0; x < BLOCK_COLUMN_COUNT; x++)
                {
                    //以下の！はnull排除演算子といって変数にnullがないことを示している
                    if (!isBroken[y, x])
                    {
                        DrawBlock(g, x, y, color);
                    }
                }
            }
        }
        private void DrawBlock(Graphics g, int column,int row, Color color)
        {
            Rectangle rect = GetBlockRect(column,row);
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, rect);
            g.DrawRectangle(new Pen (Color.Black), rect);
        }
        Rectangle GetBlockRect(int column,int row)
        {
            Rectangle rect = new Rectangle(
                    new Point(column * BLOCK_WIDTH + FIELD_POSITION_X, row * BLOCK_HEIGHT + FIELD_POSITION_Y + 20),
                    new Size(BLOCK_WIDTH, BLOCK_HEIGHT)
                );
            return rect;

        }
        private void F_Main_Load(object sender, EventArgs e)
        {
        }
        private void F_MainForm_Closed(object sender, EventArgs e)
        {
            Close();
        }
    }
}
