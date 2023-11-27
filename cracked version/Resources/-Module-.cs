using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002E8C File Offset: 0x0000108C
	static <Module>()
	{
		<Module>.ReciprocalStep = new int[]
		{
			2,
			16,
			4,
			37,
			255,
			8,
			15,
			14,
			40,
			5051,
			58,
			3072,
			21,
			22,
			61
		};
		<Module>.Tag = new int[]
		{
			1,
			0,
			32,
			6,
			17,
			150,
			178,
			232,
			10,
			64,
			9,
			11,
			12,
			19,
			23,
			24,
			27
		};
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002EE0 File Offset: 0x000010E0
	internal static void FamANDAssem(ref string A_0, object[] A_1)
	{
		<Module>.PInvokeAttributes pinvokeAttributes = new <Module>.PInvokeAttributes();
		pinvokeAttributes.__9__64_0 = 0;
		foreach (object obj in A_1)
		{
			string text = obj as string;
			if (text == null)
			{
				if (obj is int)
				{
					int num = (int)obj;
					pinvokeAttributes.__9__64_0 += num;
				}
				else if (obj is bool)
				{
					bool flag = (bool)obj;
					pinvokeAttributes.__9__64_0 += (flag ? 1 : 0);
				}
				else if (obj is char)
				{
					char c = (char)obj;
					pinvokeAttributes.__9__64_0 += (int)c;
				}
			}
			else
			{
				pinvokeAttributes.__9__64_0 = text.Aggregate(pinvokeAttributes.__9__64_0, new Func<int, char, int>(<Module>.get_MajorRevision.X00_S9.UseDllDirectoryForDependencies));
			}
		}
		A_0 = A_0.Aggregate(string.Empty, new Func<string, char, string>(pinvokeAttributes.CallConvs));
	}

	// Token: 0x04000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	internal static __StaticArrayInitTypeSize=68 MbcsJson;

	// Token: 0x04000002 RID: 2
	public static int[] Tag;

	// Token: 0x04000003 RID: 3 RVA: 0x00002098 File Offset: 0x00000298
	internal static __StaticArrayInitTypeSize=60 IsSpecialName;

	// Token: 0x04000004 RID: 4
	public static int[] ReciprocalStep;

	// Token: 0x04000005 RID: 5 RVA: 0x000020D8 File Offset: 0x000002D8
	internal static __StaticArrayInitTypeSize=44 Popi_popi8;

	// Token: 0x04000006 RID: 6
	public static int[] Cgt = new int[]
	{
		180,
		31,
		25,
		20,
		3,
		5,
		7,
		13,
		18,
		29,
		30
	};

	// Token: 0x02000002 RID: 2
	[CompilerGenerated]
	private sealed class PInvokeAttributes
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000022F8 File Offset: 0x000004F8
		internal PInvokeAttributes()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002FDC File Offset: 0x000011DC
		internal string CallConvs(string A_1, char A_2)
		{
			return A_1 + ((char)((int)A_2 ^ this.__9__64_0)).ToString();
		}

		// Token: 0x04000007 RID: 7
		internal int __9__64_0;
	}

	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[Serializable]
	private sealed class get_MajorRevision
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002300 File Offset: 0x00000500
		internal int UseDllDirectoryForDependencies(int A_1, char A_2)
		{
			return A_1 + (int)A_2;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022F8 File Offset: 0x000004F8
		internal get_MajorRevision()
		{
		}

		// Token: 0x04000008 RID: 8
		internal static Func<int, char, int> CountedUtf16Json;

		// Token: 0x04000009 RID: 9
		internal static readonly <Module>.get_MajorRevision X00_S9 = new <Module>.get_MajorRevision();
	}
}
