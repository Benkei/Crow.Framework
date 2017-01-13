using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	[DebuggerDisplay ( "V:{specVersion} {ExtensionName}" )]
	unsafe partial struct ExtensionProperties
	{
		public string ExtensionName
		{
			get
			{
				fixed ( byte* ptr = this.extensionName )
					return new string ( (sbyte*)ptr );
			}
		}
	}
}
