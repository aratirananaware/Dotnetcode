using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ConsoleApp2
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }

    }

	public class PlayerImplementation
	{
		public double Average(IList<Player> p)
		{
			double temp = 0, count = 0;
			foreach (var v in p)
			{
				temp += v.Score; count++;
			}
			temp = temp / count;
			return temp;
		}

		public int Max(IList<Player> p)
		{
			int max = 0;
			foreach (var v in p)
			{
				if (v.Score > max) max = v.Score;
			}
			return max;
		}

		public int Min(IList<Player> p)
		{
			int min = 99999999;
			foreach (var v in p)
			{
				if (v.Score < min) min = v.Score;
			}
			return min;
		}

		public static void Main1()
		{
			IList<Player> p = new List<Player>();
			p.Add(new Player { Name = "arati", Team = "b", Score = 20 });
			p.Add(new Player { Name = "gita", Team = "c", Score = 30 });
			p.Add(new Player { Name = "nita", Team = "d", Score = 10 });

			PlayerImplementation p1 = new PlayerImplementation();
			Console.WriteLine("average "+p1.Average(p));
			Console.WriteLine("Max "+p1.Max(p));
			Console.WriteLine("Min "+p1.Min(p));

			
		}
	}

}
