using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct Offset2D
	{
		public Offset2D(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}
