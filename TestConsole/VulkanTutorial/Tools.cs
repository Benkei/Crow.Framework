using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.VulkanTutorial
{
	public static class Tools
	{
		// ************************************************************ //
		// GetPerspectiveProjectionMatrix                               //
		//                                                              //
		// Function calculating perspective projection matrix           //
		// ************************************************************ //
		public static float[] GetPerspectiveProjectionMatrix(
			float aspect_ratio,
			float field_of_view,
			float near_clip,
			float far_clip)
		{
			float f = 1.0f / (float)Math.Tan ( field_of_view * 0.5f * 0.01745329251994329576923690768489f );
			return new[]{
				f / aspect_ratio,
				0.0f,
				0.0f,
				0.0f,

				0.0f,
				f,
				0.0f,
				0.0f,

				0.0f,
				0.0f,
				(near_clip + far_clip) / (near_clip - far_clip),
				-1.0f,

				0.0f,
				0.0f,
				(2.0f * near_clip * far_clip) / (near_clip - far_clip),
				0.0f
			};
		}

		// ************************************************************ //
		// GetOrthographicsProjectionMatrix                             //
		//                                                              //
		// Function calculating orthographic projection matrix          //
		// ************************************************************ //
		public static float[] GetOrthographicProjectionMatrix(
			float left_plane,
			float right_plane,
			float top_plane,
			float bottom_plane,
			float near_plane,
			float far_plane)
		{
			return new[]{
				2.0f / (right_plane - left_plane),
				0.0f,
				0.0f,
				0.0f,

				0.0f,
				2.0f / (bottom_plane - top_plane),
				0.0f,
				0.0f,

				0.0f,
				0.0f,
				-2.0f / (far_plane - near_plane),
				0.0f,

				-(right_plane + left_plane) / (right_plane - left_plane),
				-(bottom_plane + top_plane) / (bottom_plane - top_plane),
				-(far_plane + near_plane) / (far_plane - near_plane),
				1.0f
			};
		}
	}
}
