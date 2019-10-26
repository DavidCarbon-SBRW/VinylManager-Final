using System;
using System.Runtime.InteropServices;

internal class Class6
{
	private int int_0;

	public Class6(string string_0)
	{
		Class9.gVVuj4FzFXpvb();
		base();
		this.int_0 = Class6.FindWindow(null, string_0);
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern int FindWindow(string string_0, string string_1);

	private IntPtr hpCewjupsG(short short_0, short short_1)
	{
		return (IntPtr)(short_1 << 16 | short_0 & 65535);
	}

	public void method_0(IntPtr intptr_0)
	{
		Class6.PostMessage(this.int_0, 256, intptr_0, IntPtr.Zero);
	}

	public void method_1(short short_0, short short_1)
	{
		IntPtr intPtr = this.hpCewjupsG(short_0, short_1);
		Class6.PostMessage(this.int_0, 513, IntPtr.Zero, intPtr);
		Class6.PostMessage(this.int_0, 514, IntPtr.Zero, intPtr);
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	public static extern bool PostMessage(int int_1, uint uint_0, IntPtr intptr_0, IntPtr intptr_1);
}