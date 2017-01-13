using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct LayerProperties
	{
		public string LayerName
		{
			get
			{
				fixed ( byte* ptr = this.layerName )
					return new string ( (sbyte*)ptr );
			}
		}
		public string Description
		{
			get
			{
				fixed ( byte* ptr = this.description )
					return new string ( (sbyte*)ptr );
			}
		}
	}
}
