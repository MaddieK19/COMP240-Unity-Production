using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//TO DO: Now our grid needs to know about the canvas and the prefab. 

public class HexMap : MonoBehaviour
{

    public int xSize = 15;
    public int ySize = 15;
    public HexMap cellPrefab;


    //working our the inner and outer radius
    public static class HexMetrics
    {
        public const float outerRadius = 10f;
        public const float innerRadius = outerRadius * 0.866025404f;
    }

    //working out the corners in relation to the center
    public static Vector3[] corners = {
        new Vector3(0f, 0f, outerRadius),
        new Vector3(innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(0f, 0f, -outerRadius),
        new Vector3(-innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(-innerRadius, 0f, 0.5f * outerRadius)
    };


    //creating a square grid
    HexMap[] cells;

    public Text cellLabelPrefab;

    Canvas gridCanvas;

    void Awake()
    {
        gridCanvas = GetComponentInChildren<Canvas>();

        cells = new HexMap[xSize * ySize];

        for (int z = 0, i = 0; z < ySize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {
                CreateCell(x, z, i++);
            }
        }
    }

    void CreateCell(int x, int z, int i)
    {
        Vector3 position;
        position.x = x * 10f;
        position.y = 0f;
        position.z = z * 10f;

        HexMap cell = cells[i] = Instantiate<HexMap>(cellPrefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = position;
    }
}