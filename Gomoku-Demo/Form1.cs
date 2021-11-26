﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku_Demo
{
    public partial class Form1 : Form
    {
        private Board board = new Board();

        private PieceType nextPieceType = PieceType.BLACK;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Piece piece = board.PlaceAPiece(e.X, e.Y, nextPieceType);
            if (piece != null)//如果有棋子
            {
                this.Controls.Add(piece);

                if (nextPieceType == PieceType.BLACK)
                    nextPieceType = PieceType.WHITE;
                else if (nextPieceType == PieceType.WHITE)
                    nextPieceType = PieceType.BLACK;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (board.CanBePlaced(e.X, e.Y))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}