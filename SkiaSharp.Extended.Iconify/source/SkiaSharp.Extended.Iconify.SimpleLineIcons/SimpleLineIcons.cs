﻿using System;
using System.IO;
using System.Reflection;

namespace SkiaSharp.Extended.Iconify
{
	public static partial class SimpleLineIcons
	{
		public const string ManifestResourceName = "SkiaSharp.Extended.Iconify.Simple-Line-Icons.ttf";

		public static Stream GetFontStream()
		{
			var type = typeof(SimpleLineIcons).GetTypeInfo();
			var assembly = type.Assembly;

			return assembly.GetManifestResourceStream(ManifestResourceName);
		}

		public static SKTypeface GetTypeface()
		{
			return SKTypeface.FromStream(GetFontStream());
		}

		public static void AddTo(SKTextRunLookup lookup)
		{
			if (lookup == null)
				throw new ArgumentNullException(nameof(lookup));
			lookup.AddTypeface(GetTypeface(), Characters);
		}
	}
}