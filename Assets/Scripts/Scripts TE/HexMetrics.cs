using UnityEngine;

public static class HexMetrics {

	public const float outerRadius = 1f;

	public const float innerRadius = outerRadius * 0.866025404f;//radious of the hexagons

	public static Vector3[] corners = {
		new Vector3(0f, 0f, outerRadius),
		new Vector3(innerRadius, 0f, 0.5f * outerRadius),
		new Vector3(innerRadius, 0f, -0.5f * outerRadius),
		new Vector3(0f, 0f, -outerRadius),
		new Vector3(-innerRadius, 0f, -0.5f * outerRadius),
		new Vector3(-innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(0f, 0f, outerRadius)//prevents out of radius by duplicating the 1st corner otherwise goes for a seventh
    }; //defining the six corners in relation to the center
}