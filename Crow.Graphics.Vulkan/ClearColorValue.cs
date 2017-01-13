using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct ClearColorValue
	{
		public ClearColorValue(float r, float g, float b, float a)
		{
			fixed ( float* ptr = float32 )
			{
				ptr[0] = r;
				ptr[1] = g;
				ptr[2] = b;
				ptr[3] = a;
			}
		}
		public ClearColorValue(uint r, uint g, uint b, uint a)
		{
			fixed ( uint* ptr = uint32 )
			{
				ptr[0] = r;
				ptr[1] = g;
				ptr[2] = b;
				ptr[3] = a;
			}
		}
		public ClearColorValue(int r, int g, int b, int a)
		{
			fixed ( int* ptr = int32 )
			{
				ptr[0] = r;
				ptr[1] = g;
				ptr[2] = b;
				ptr[3] = a;
			}
		}
	}
}
