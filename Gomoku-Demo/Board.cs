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

        public bool CanBePlaced(int x, int y)
        {
            //找出最近的節點(Node)
            Point nodeId = FindTheClosetNode(x, y);

            //如果沒有的話,回傳 false
            if (nodeId == No_MATCH_NODE)
                return false;
            //ToDo: 如果有的話,檢查是否有棋子存在

            return true;
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