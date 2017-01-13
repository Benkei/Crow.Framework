using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	[Serializable]
	public class VulkanException : Exception
	{
		public Result ResultCode { get; }

		public VulkanException(Result resultCode)
		{
			ResultCode = resultCode;
		}
		public VulkanException(Result resultCode, string message) : base ( message )
		{
			ResultCode = resultCode;
		}
		public VulkanException(Result resultCode, string message, Exception inner) : base ( message, inner )
		{
			ResultCode = resultCode;
		}
		protected VulkanException(
		 System.Runtime.Serialization.SerializationInfo info,
		 System.Runtime.Serialization.StreamingContext context) : base ( info, context ) { }
	}
}
