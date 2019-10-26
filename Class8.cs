using System;
using System.Reflection;

internal class Class8
{
	internal static Module module_0;

	static Class8()
	{
		Class9.gVVuj4FzFXpvb();
		Class8.module_0 = typeof(Class8).Assembly.ManifestModule;
	}

	public Class8()
	{
		Class9.gVVuj4FzFXpvb();
		base();
	}

	internal static void laCuj4FFqsvig(int typemdt)
	{
		Type type = Class8.module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		for (int i = 0; i < (int)fields.Length; i++)
		{
			FieldInfo fieldInfo = fields[i];
			MethodInfo methodInfo = (MethodInfo)Class8.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, methodInfo));
		}
	}

	internal delegate void Delegate8(object o);
}