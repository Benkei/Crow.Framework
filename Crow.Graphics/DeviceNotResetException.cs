using System;

namespace Crow.Graphics
{
	public sealed class DeviceNotResetException : Exception
	{
		public DeviceNotResetException()
			 : base ()
		{
		}

		public DeviceNotResetException(string message)
			 : base ( message )
		{
		}

		public DeviceNotResetException(string message, Exception inner)
			 : base ( message, inner )
		{
		}
	}
}