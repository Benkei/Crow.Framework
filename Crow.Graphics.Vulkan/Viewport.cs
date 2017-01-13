using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct Viewport
	{
		public Viewport(float x, float y, float width, float height, float minDepth, float maxDepth)
		{
			this.x = x; this.y = y;
			this.width = width; this.height = height;
			this.minDepth = minDepth; this.maxDepth = maxDepth;
		}
	}
}
