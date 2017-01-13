using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct Extent3D
	{
		public Extent3D(uint width, uint height, uint depth)
		{
			this.width = width; this.height = height; this.depth = depth;
		}
	}
}
