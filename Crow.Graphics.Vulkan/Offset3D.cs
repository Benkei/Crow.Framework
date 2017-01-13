using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct Offset3D
	{
		public Offset3D(int x, int y, int z)
		{
			this.x = x; this.y = y; this.z = z;
		}
	}
}
