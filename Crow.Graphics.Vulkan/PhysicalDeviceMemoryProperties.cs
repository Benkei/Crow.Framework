using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	unsafe partial struct PhysicalDeviceMemoryProperties
	{
		public MemoryType[] GetMemoryTypes
		{
			get
			{
				fixed ( int* ptr = memoryTypes )
				{
					var result = new MemoryType[memoryTypeCount];
					for ( int i = 0; i < memoryTypeCount; i++ )
					{
						result[i] = ((MemoryType*)ptr)[i];
					}
					return result;
				}
			}
		}
		public MemoryHeap[] GetMemoryHeaps
		{
			get
			{
				fixed ( int* ptr = memoryHeaps )
				{
					var result = new MemoryHeap[memoryHeapCount];
					for ( int i = 0; i < memoryHeapCount; i++ )
					{
						result[i] = ((MemoryHeap*)ptr)[i];
					}
					return result;
				}
			}
		}
	}
}
