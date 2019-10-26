using System;
using System.Globalization;
using System.Linq;
using System.Text;

internal class Class3
{
	private Random random_0;

	public Class3(int int_0)
	{
		Class9.gVVuj4FzFXpvb();
		base();
		this.random_0 = new Random(int_0);
	}

	private string method_10(string string_0, int int_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (int_0 == 0 || string_0.Length == 0)
		{
			return "";
		}
		if (string_0.Length <= int_0)
		{
			return string_0;
		}
		return string_0.Substring(0, int_0);
	}

	private string method_11(string string_0, int int_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		if (int_0 == 0 || string_0.Length == 0)
		{
			return string_0;
		}
		if (string_0.Length <= int_0)
		{
			return "";
		}
		return string_0.Substring(int_0, string_0.Length - int_0);
	}

	public string method_6(string string_0)
	{
		byte[] bytes = (new UTF8Encoding()).GetBytes(string_0);
		bytes = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(1251), bytes);
		string str = "";
		byte[] numArray = bytes;
		for (int i = 0; i < (int)numArray.Length; i++)
		{
			byte num = numArray[i];
			str = string.Concat(str, (num > 15 ? string.Format("{0:X}", num) : string.Format("0{0:X}", num)));
		}
		return str;
	}

	public string method_7(string string_0)
	{
		string str;
		try
		{
			string empty = string.Empty;
			for (int i = 0; i < string_0.Length; i += 2)
			{
				string str1 = string_0[i].ToString();
				char string0 = string_0[i + 1];
				empty = string.Concat(empty, str1, string0.ToString(), " ");
			}
			char[] chrArray = new char[] { ' ' };
			string[] strArrays = empty.Split(chrArray, StringSplitOptions.RemoveEmptyEntries);
			byte[] numArray = new byte[(int)strArrays.Length];
			for (int j = 0; j < (int)strArrays.Length; j++)
			{
				numArray[j] = byte.Parse(strArrays[j], NumberStyles.AllowHexSpecifier);
			}
			str = Encoding.GetEncoding(1251).GetString(numArray);
		}
		catch
		{
			str = "";
		}
		return str;
	}

	private string method_8(string string_0, bool bool_0)
	{
		int num;
		if (string_0.Length == 0)
		{
			return "";
		}
		int num1 = 0;
		if (!bool_0)
		{
			int length = string_0.Length;
			num = Convert.ToInt32(this.method_10(string_0, 2));
			string_0 = this.method_11(string_0, 2);
		}
		else
		{
			int length1 = string_0.Length;
			num1 = this.random_0.Next(10, 99);
			num = num1;
		}
		char[] charArray = string_0.ToCharArray();
		for (int i = 0; i < charArray.Count<char>(); i++)
		{
			charArray[i] = Convert.ToChar(charArray[i] ^ (char)num);
			if (num >= 98)
			{
				num = 0;
			}
			else
			{
				num++;
			}
		}
		return string.Concat((bool_0 ? num1.ToString() : ""), new string(charArray));
	}

	public string method_9(string string_0, bool bool_0)
	{
		int num;
		int num1;
		if (string_0.Length == 0)
		{
			return "";
		}
		int num2 = 0;
		if (!bool_0)
		{
			int length = string_0.Length;
			num1 = Convert.ToInt32(this.method_10(string_0, 2));
			string_0 = this.method_11(string_0, 2);
		}
		else
		{
			int length1 = string_0.Length;
			num2 = this.random_0.Next(10, 20);
			num1 = num2;
		}
		char[] charArray = string_0.ToCharArray();
		for (int i = 0; i < charArray.Count<char>(); i++)
		{
			num = (i % 2 != 1 ? 2 : 1);
			charArray[i] = Convert.ToChar(charArray[i] ^ (char)(num1 * num));
		}
		return string.Concat((bool_0 ? num2.ToString() : ""), new string(charArray));
	}
}