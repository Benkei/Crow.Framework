using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	public static class ResultUtil
	{
		public static bool Success(this Result code)
		{
			return code >= 0;
		}

		public static bool Error(this Result code)
		{
			return code < 0;
		}

		public static Result CheckError(this Result code)
		{
			if ( code < 0 )
			{
				throw new VulkanException ( code );
			}
			return code;
		}

		public static Result CheckError(this Result code, string message)
		{
			if ( code < 0 )
			{
				throw new VulkanException ( code, message );
			}
			return code;
		}

		public static Result CheckError<T0>(this Result code, string format, T0 arg0)
		{
			if ( code < 0 )
			{
				throw new VulkanException ( code, string.Format ( format, arg0 ) );
			}
			return code;
		}

		public static Result CheckError<T0, T1>(this Result code, string format, T0 arg0, T1 arg1)
		{
			if ( code < 0 )
			{
				throw new VulkanException ( code, string.Format ( format, arg0, arg1 ) );
			}
			return code;
		}

		public static Result CheckError<T0, T1, T2>(this Result code, string format, T0 arg0, T1 arg1, T2 arg2)
		{
			if ( code < 0 )
			{
				throw new VulkanException ( code, string.Format ( format, arg0, arg1, arg2 ) );
			}
			return code;
		}

		public static Result CheckError(this Result code, string format, params object[] args)
		{
			if ( code < 0 )
			{
				throw new VulkanException ( code, string.Format ( format, args ) );
			}
			return code;
		}
	}
}
