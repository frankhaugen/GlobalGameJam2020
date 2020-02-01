using UnityEngine;

static class Geometry
{
    public static void CartesianToSpherical(Vector3 cartCoords, out float outRadius, out float outPolar, out float outElevation)
    {
        if (cartCoords.x == 0)
            cartCoords.x = Mathf.Epsilon;
        outRadius = Mathf.Sqrt((cartCoords.x * cartCoords.x)
                               + (cartCoords.y * cartCoords.y)
                               + (cartCoords.z * cartCoords.z));
        outPolar = Mathf.Atan(cartCoords.z / cartCoords.x);
        if (cartCoords.x < 0)
            outPolar += Mathf.PI;
        outElevation = Mathf.Asin(cartCoords.y / outRadius);
    }

    public static void SphericalToCartesian(float radius, float polar, float elevation, out Vector3 outCart)
    {
        float a = radius * Mathf.Cos(elevation);
        outCart.x = a * Mathf.Cos(polar);
        outCart.y = radius * Mathf.Sin(elevation);
        outCart.z = a * Mathf.Sin(polar);
    }

    public static float EuclideanDistance(Vector3 origin, Vector3 destination)
    {
        var x = Mathf.Pow(origin.x - destination.x, 2);
        var y = Mathf.Pow(origin.y - destination.y, 2);
        var z = Mathf.Pow(origin.z - destination.z, 2);
        return Mathf.Sqrt(x + y + z);
    }
}
