using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct Extent2D
	{
		public Extent2D(uint width, uint height)
		{
			this.width = width;
			this.height = height;
		}
	}
}
