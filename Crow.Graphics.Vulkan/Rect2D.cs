using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct Rect2D
	{
		public Rect2D(Offset2D offset, Extent2D extent)
		{
			this.offset = offset;
			this.extent = extent;
		}
	}
}
