﻿using Il2CppCollections = Il2CppSystem.Collections.Generic;
using Standard = System.Collections.Generic;

namespace ModComponent.Utils;

internal static class ConversionUtils
{
	internal static Standard.List<T> Convert<T>(Il2CppCollections.List<T> list)
	{
		Standard.List<T> result = new Standard.List<T>(list.Count);
		foreach (T? element in list)
		{
			result.Add(element);
		}

		return result;
	}
	internal static Il2CppCollections.List<T> Convert<T>(Standard.List<T> list)
	{
		Il2CppCollections.List<T> result = new Il2CppCollections.List<T>(list.Count);
		foreach (T? element in list)
		{
			result.Add(element);
		}

		return result;
	}
	internal static Il2CppCollections.List<T> Convert<T>(T[] array)
	{
		Il2CppCollections.List<T> result = new Il2CppCollections.List<T>(array.Length);
		foreach (T? element in array)
		{
			result.Add(element);
		}

		return result;
	}
	internal static Standard.List<T> Convert<T>(Il2CppCollections.IEnumerable<T> enumerable)
	{
		Il2CppCollections.List<T> temp = new Il2CppCollections.List<T>(enumerable);
		Standard.List<T> result = new Standard.List<T>(temp.Count);
		foreach (T? element in temp)
		{
			result.Add(element);
		}

		return result;
	}

	internal static T[] ToArray<T>(Standard.List<T> list) => list.ToArray();
	internal static T[] ToArray<T>(Il2CppCollections.List<T> list)
	{
		T[] result = new T[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			result[i] = list[i];
		}

		return result;
	}
	internal static T[] ToArray<T>(Il2CppCollections.IEnumerable<T> enumerable) => ToArray(new Il2CppCollections.List<T>(enumerable));
}
