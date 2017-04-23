using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class HexMesh : MonoBehaviour //hexmesh takes care of mesh
{

    Mesh hexMesh;
    List<Vector3> vertices;
    List<Color> colors;
    List<int> triangles;

    MeshCollider meshCollider;

    void Awake()
    {
        GetComponent<MeshFilter>().mesh = hexMesh = new Mesh(); //adding filter
        meshCollider = gameObject.AddComponent<MeshCollider>();//collider
        hexMesh.name = "Hex Mesh";
        vertices = new List<Vector3>();
        colors = new List<Color>();
        triangles = new List<int>();
    }

    public void Triangulate(HexCell[] cells)
    {
        hexMesh.Clear();//clearing ye oldie data
        vertices.Clear();
        colors.Clear();
        triangles.Clear();
        for (int i = 0; i < cells.Length; i++)
        {
            Triangulate(cells[i]); //looping through triangulating cells
        }
        hexMesh.vertices = vertices.ToArray();
        hexMesh.colors = colors.ToArray();//assigning vertices triangles to mesh
        hexMesh.triangles = triangles.ToArray();
        hexMesh.RecalculateNormals();//calculating mesh norms
        meshCollider.sharedMesh = hexMesh;
    }

    void Triangulate(HexCell cell)//positioning triangles
    {
        Vector3 center = cell.transform.localPosition;
        for (int i = 0; i < 6; i++) //going through each positioning it by it vertices
        {
            AddTriangle(
                center,
                center + HexMetrics.corners[i],
                center + HexMetrics.corners[(i+1)%6]
            );
            AddTriangleColor(cell.color);
        }
    }
    /*This is the method of adding the triangle*/
    void AddTriangle(Vector3 v1, Vector3 v2, Vector3 v3)
    {
        int vertexIndex = vertices.Count;//adding vertices in order
        vertices.Add(v1);
        vertices.Add(v2);
        vertices.Add(v3);
        triangles.Add(vertexIndex);
        triangles.Add(vertexIndex + 1);
        triangles.Add(vertexIndex + 2);
    }

    void AddTriangleColor(Color color)
    {
        colors.Add(color);
        colors.Add(color);
        colors.Add(color);
    }
}