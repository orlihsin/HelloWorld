using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gomoku_Demo
{
    internal class Board
    {
        private static readonly Point No_MATCH_NODE = new Point(-1, -1);
        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTRANCE = 75;

        private Piece[,] pieces = new Piece[9, 9];

        public bool CanBePlaced(int x, int y)
        {
            //找出最近的節點(Node)
            Point nodeId = FindTheClosetNode(x, y);

            //如果沒有的話,回傳 false
            if (nodeId == No_MATCH_NODE)
                return false;
            //如果有的話,檢查是否有棋子存在
            if (nodeId.X >= 9 || nodeId.Y >= 9) return false;
            if (pieces[nodeId.X, nodeId.Y] != null)
                return false;

            return true;
        }

        public Piece PlaceAPiece(int x, int y, PieceType type)
        {
            // //找出最近的節點(Node)
            Point nodeId = FindTheClosetNode(x, y);

            //如果沒有的話,回傳 false
            if (nodeId == No_MATCH_NODE)
                return null;

            //如果有的話,檢查是否有棋子存在
            if (pieces[nodeId.X, nodeId.Y] != null)
                return null;

            //根據type 產生對應的棋子
            Point formPos = convertToFormPosition(nodeId);
            if (type == PieceType.BLACK)
                pieces[nodeId.X, nodeId.Y] = new BlackPiece(formPos.X, formPos.Y);
            else if (type == PieceType.WHITE)
                pieces[nodeId.X, nodeId.Y] = new WhitePiece(formPos.X, formPos.Y);

            return pieces[nodeId.X, nodeId.Y];
        }

        private Point convertToFormPosition(Point nodeId)
        {
            Point FormPosition = new Point();

            FormPosition.X = nodeId.X * NODE_DISTRANCE + OFFSET;
            FormPosition.Y = nodeId.Y * NODE_DISTRANCE + OFFSET;
            return FormPosition;
        }

        private Point FindTheClosetNode(int x, int y)
        {
            int nodeIdX = FindTheCloseNode(x);
            if (nodeIdX == -1)
                return No_MATCH_NODE;

            int nodeIdY = FindTheCloseNode(y);
            if (nodeIdY == -1)
                return No_MATCH_NODE;
            return new Point(nodeIdX, nodeIdY);
        }

        private int FindTheCloseNode(int pos)
        {
            pos -= OFFSET;
            if (pos <= 0) return -1;

            int quotient = pos / NODE_DISTRANCE;
            int remainder = pos % NODE_DISTRANCE;

            if (remainder <= NODE_RADIUS)
                return quotient;
            else if (remainder >= NODE_DISTRANCE - NODE_RADIUS)
                return quotient + 1;
            else
                return -1;
        }
    }
}