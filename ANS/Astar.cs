using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANS
{
	class Astar
	{
		/*List<Node> open = new List<Node>();
		List<Node> closed = new List<Node>();
		public void AStar(Node start, Node slut)
		{

		}*/

		public List<int> cellList = new List<int>();

		/*public List<Cell> openSet = new List<Cell>();
		List<Cell> closedSet = new List<Cell>();
		public void AStar(Cell start, Cell slut)
		{
			openSet.Add(start);
			while (openSet != null)
			{
				//int current = LowestNmb()  
			}
		}*/




		static int LowestNmb(List<int> list)
		{

			int lowest = list[0];
			for (int i = 1; i < list.Count; i++)
			{
				if (list[i] < lowest)
				{
					lowest = list[i];
				}
			}
			return lowest;

		}

		public List<int> Neighbours(Cell n)
		{

			for (int x = -1; x == 1; x++)
			{
				for (int y = -1; y == 1; y++)
				{
					int xPos = n.position.X + x;
					int yPos = n.position.Y + y;

					if (xPos >= 0 && xPos <= 10 &&
						yPos >= 0 && yPos <= 10)
					{

					}

				}
			}

			return cellList;
		}
	}
}
