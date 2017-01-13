using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crow.Graphics.Vulkan
{
	[DebuggerDisplay ( "{ToString()}" )]
	public unsafe struct Boolean32
		: IConvertible,
		IEquatable<Boolean32>, IEquatable<Boolean>,
		IComparable<Boolean32>, IComparable<Boolean>
	{
		private int raw;

		public static readonly Boolean32 True = new Boolean32 ( true );
		public static readonly Boolean32 False = new Boolean32 ( false );


		public Boolean32(bool value)
		{
			raw = *(byte*)&value;
		}


		public int CompareTo(bool other)
		{
			return raw.CompareTo ( *(byte*)&other );
		}

		public int CompareTo(Boolean32 other)
		{
			return raw.CompareTo ( other.raw );
		}

		public bool Equals(bool other)
		{
			return raw == *(byte*)&other;
		}

		public bool Equals(Boolean32 other)
		{
			return raw == other.raw;
		}

		public override int GetHashCode()
		{
			return raw.GetHashCode ();
		}

		public override bool Equals(object obj)
		{
			return obj is Boolean32 && raw == ((Boolean32)obj).raw;
		}

		public override string ToString()
		{
			return ((bool)this).ToString ();
		}

		#region IConvertible

		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Int32;
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			int _raw = raw;
			return *(bool*)&_raw;
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return (byte)raw;
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			return (char)raw;
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return default ( DateTime );
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return raw;
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return raw;
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return (short)raw;
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return raw;
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return raw;
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return (sbyte)raw;
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return raw;
		}

		string IConvertible.ToString(IFormatProvider provider)
		{
			bool b = this;
			return b.ToString ( provider );
		}

		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			/*
			switch ( Type.GetTypeCode ( conversionType ) )
			{
				//case TypeCode.Empty: break;
				//case TypeCode.Object: break;
				//case TypeCode.DBNull: break;
				case TypeCode.Boolean: return this.ToBoolean ( provider ); break;
				case TypeCode.Char: break;
				case TypeCode.SByte: break;
				case TypeCode.Byte: break;
				case TypeCode.Int16: break;
				case TypeCode.UInt16: break;
				case TypeCode.Int32: break;
				case TypeCode.UInt32: break;
				case TypeCode.Int64: break;
				case TypeCode.UInt64: break;
				case TypeCode.Single: break;
				case TypeCode.Double: break;
				case TypeCode.Decimal: break;
				case TypeCode.DateTime: break;
				case TypeCode.String: break;

				default: return null;
			}
			*/
			throw new NotImplementedException ();
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return (ushort)raw;
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return (uint)raw;
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return (ulong)raw;
		}

		#endregion

		public static implicit operator Boolean(Boolean32 d)
		{
			return *(bool*)&d.raw;
		}

		public static implicit operator Boolean32(Boolean d)
		{
			return new Boolean32 ( d );
		}
	}
}
