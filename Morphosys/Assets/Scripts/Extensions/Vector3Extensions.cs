using System.Text;
using UnityEngine;

public static class Vector3Extensions
{
    public static string ToHudString(this Vector3 vector3)
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"X: {vector3.x.ToString()}");
        stringBuilder.AppendLine($"Y: {vector3.y.ToString()}");
        stringBuilder.AppendLine($"Z: {vector3.z.ToString()}");
        stringBuilder.AppendLine($"Sum: {(vector3.x + vector3.y + vector3.z).ToString()}");

        return stringBuilder.ToString();
    }
}
