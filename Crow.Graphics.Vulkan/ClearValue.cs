using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct ClearValue
	{
		public ClearValue(ClearColorValue color) : this ()
		{
			this.color = color;
		}
		public ClearValue(ClearDepthStencilValue depthStencil) : this ()
		{
			this.depthStencil = depthStencil;
		}
	}
}
