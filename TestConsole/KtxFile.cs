using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
	/*
Byte[12] identifier
UInt32 endianness
UInt32 glType
UInt32 glTypeSize
UInt32 glFormat
Uint32 glInternalFormat
Uint32 glBaseInternalFormat
UInt32 pixelWidth
UInt32 pixelHeight
UInt32 pixelDepth
UInt32 numberOfArrayElements
UInt32 numberOfFaces
UInt32 numberOfMipmapLevels
UInt32 bytesOfKeyValueData
  
for each keyValuePair that fits in bytesOfKeyValueData
	 UInt32   keyAndValueByteSize
	 Byte     keyAndValue[keyAndValueByteSize]
	 Byte     valuePadding[3 - ((keyAndValueByteSize + 3) % 4)]
end
  
for each mipmap_level in numberOfMipmapLevels*
	 UInt32 imageSize; 
	 for each array_element in numberOfArrayElements*
		 for each face in numberOfFaces
			  for each z_slice in pixelDepth*
					for each row or row_of_blocks in pixelHeight*
						 for each pixel or block_of_pixels in pixelWidth
							  Byte data[format-specific-number-of-bytes]**
						 end
					end
			  end
			  Byte cubePadding[0-3]
		 end
	 end
	 Byte mipPadding[3 - ((imageSize + 3) % 4)]
end

* Replace with 1 if this field is 0.
** Uncompressed texture data matches a GL_UNPACK_ALIGNMENT of 4.
	 */
	class KtxFile
	{
		int identifier0;
		int identifier1;
		int identifier2;

		int endianness;
		int glType;
		int glTypeSize;
		int glFormat;
		int glInternalFormat;
		int glBaseInternalFormat;
		int pixelWidth;
		int pixelHeight;
		int pixelDepth;
		int numberOfArrayElements;
		int numberOfFaces;
		int numberOfMipmapLevels;
		int bytesOfKeyValueData;

		private void ReadKeyValue(BinaryReader stream)
		{
			var keyAndValueByteSize = stream.ReadInt32 ();
			var keyAndValue = stream.ReadBytes ( keyAndValueByteSize );
			var valuePadding = 3 - ((keyAndValueByteSize + 3) % 4);
			for ( int i = 0; i < valuePadding; i++ )
			{
				stream.ReadByte (); // skip bytes
			}

			var keyLenth = Array.IndexOf ( keyAndValue, 0 );

			var key = Encoding.UTF8.GetString ( keyAndValue, 0, keyLenth );
			var value = new byte[keyAndValueByteSize - keyLenth];

			Array.Copy ( keyAndValue, keyLenth, value, 0, value.Length );
		}

		private void Read(BinaryReader stream)
		{
			int mipmapCount = Math.Min ( 1, numberOfMipmapLevels );
			int arrayCount = Math.Min ( 1, numberOfArrayElements );
			int pixelDepthCount = Math.Min ( 1, pixelDepth );
			int pixelHeightCount = Math.Min ( 1, pixelHeight );
			int pixelBlockSize = 4;
			for ( int mipmapIdx = 0; mipmapIdx < mipmapCount; mipmapIdx++ )
			{
				int imageSize = stream.ReadInt32 ();
				int mipPadding = 3 - ((imageSize + 3) % 4);
				int cubePadding = 0;
				if ( numberOfFaces == 6 && numberOfArrayElements == 0 )
				{
					cubePadding = mipPadding;
				}

				for ( int arrayIdx = 0; arrayIdx < arrayCount; arrayIdx++ )
				{
					for ( int faceIdx = 0; faceIdx < numberOfFaces; faceIdx++ )
					{
						for ( int zSlice = 0; zSlice < pixelDepthCount; zSlice++ )
						{
							for ( int row = 0; row < pixelHeightCount; row++ )
							{
								for ( int pixel = 0; pixel < pixelWidth; pixel++ )
								{
									stream.ReadBytes ( pixelBlockSize );
								}
							}
						}
						//Byte cubePadding[0 - 3]
						for ( int i = 0; i < cubePadding; i++ )
						{
							stream.ReadByte (); // skip bytes
						}
					}
				}

				for ( int i = 0; i < mipPadding; i++ )
				{
					stream.ReadByte (); // skip bytes
				}
			}
		}
	}
}
