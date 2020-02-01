using System;
using UnityEngine;

public static class FloatExtensions
{
    public static float Round(this float value, int decimals = 4)
    {
        return Convert.ToSingle(Math.Round(value, decimals));
    }

    public static float NthRoot(this float value, int N)
    {
        return Mathf.Pow(value, 1.0f / N);
    }

    public static int NthPowerOf(this float value, float N)
    {
        return Convert.ToInt32(Mathf.Pow(value, (1 / N)));
    }
}