﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.PdfRasterizer.Abstractions
{
	public static class StringExtensions
	{
		private const string PathSeparator = "/";

		public static string ToFolderPath (this string path)
		{
			return PathSeparator + string.Join (PathSeparator, path.SplitPath ()) + PathSeparator;
		}

		public static string ToFilePath (this string path)
		{
			return PathSeparator + string.Join (PathSeparator, path.SplitPath ());
		}

		public static string[] SplitPath (this string path)
		{
			return path.Split (new char[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
		}


		public static string AppendPath (this string path, string other)
		{
			return path.ToFolderPath ().TrimEnd (new char[] { '/' }) + other;
		}

		public static bool IsDistantUrl (this string url)
		{
			return url.StartsWith ("http://") || url.StartsWith ("https://");
		}
	}
}
