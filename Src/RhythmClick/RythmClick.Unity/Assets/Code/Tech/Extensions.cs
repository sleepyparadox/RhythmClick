using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Extensions
{
    public static T RandomItem<T>(this T[] items)
    {
        return items[UnityEngine.Random.Range(0, items.Length)];
    }
}
