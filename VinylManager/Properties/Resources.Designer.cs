using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace VinylManager.Properties
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		private static ResourceManager resourceManager_0;

		private static object object_0;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo CultureInfo_0
		{
			set
			{
				Resources.object_0 = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager_0
		{
			get
			{
				if (Resources.resourceManager_0 == null)
				{
					Resources.resourceManager_0 = new ResourceManager("VinylManager.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceManager_0;
			}
		}

		internal Resources()
		{
			Class9.gVVuj4FzFXpvb();
			base();
		}
	}
}