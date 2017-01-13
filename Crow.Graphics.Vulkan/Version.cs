using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	[DebuggerDisplay ( "({Major}.{Minor}.{Patch})" )]
	public struct Version
	{
		public uint Raw;

		public Version(uint raw)
		{
			Raw = raw;
		}

		public Version(uint major, uint minor, uint patch)
		{
			Raw = (major << 22) | (minor << 12) | patch;
		}

		public uint Major
		{
			get { return (Raw >> 22); }
			set { Raw = (Raw & ~(0x3ff << 22)) | (value << 22); }
		}
		public uint Minor
		{
			get { return (Raw >> 12) & 0x3ffu; }
			set { Raw = (Raw & ~(0x3ffu << 12)) | (value << 12); }
		}
		public uint Patch
		{
			get { return Raw & 0xfffu; }
			set { Raw = (Raw & ~0xfffu) | value; }
		}
	}
}
