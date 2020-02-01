using System.Text;
using UnityEngine;

public static class Vector2Extensions
{
    public static string ToHudString(this Vector2 vector2)
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"X: {vector2.x.ToString()}");
        stringBuilder.AppendLine($"Y: {vector2.y.ToString()}");
        stringBuilder.AppendLine($"Sum: {(vector2.x + vector2.y).ToString()}");

        return stringBuilder.ToString();
    }
}
