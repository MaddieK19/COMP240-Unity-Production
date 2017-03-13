//used tutorial found at http://catlikecoding.com/unity/tutorials/hex-map-1/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//procedural grid
/*
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]//gets unity to automatically add mesh filter and renderer
public class Grid : MonoBehaviour
{

    public int width, height;//Grid width and height

    private void Awake() //generates the mesh when play mode is entered
    {
        StartCoroutine(Generate());
    }

    private Vector3[] vertices; //used to represent vertex position

    private Mesh mesh; //creating the mesh

    private IEnumerator Generate() 
    {
        WaitForSeconds wait = new WaitForSeconds(0.09f); //allows you to see order drawn
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        mesh.name = "Procedural Grid";
        vertices = new Vector3[(height + 1)*(width + 1)];
        for (int i = 0, x = 0; x <= width; x++) //iterating the vertices in all position using the loop
        {
            for(int y = 0; y <= height; y++, i++)
            {
                vertices[i] = new Vector3(y, x);
                yield return wait;
            }
        }
        mesh.vertices = vertices;

        int[] triangles = new int[width * height * 6]; //making a triangle
        for (int ti = 0, vi = 0, y = 0; y < width; y++, ti += 6, vi++)
        {
            for (int x = 0; x < width; x++, ti += 6, vi++)
            {
                triangles[ti] = vi;
                triangles[ti + 1] = width + 1;
                triangles[ti + 2] = 1;             //creating the three points of a triangle
                triangles[ti + 3] = triangles[ti + 2] = vi + 1;
                triangles[ti + 4] = triangles[ti + 1] = vi + width + 1;
                triangles[ti + 5] = vi + width + 2;    //making a triangle with a different orientation
                mesh.triangles = triangles;
                yield return wait;
            }
        }
    }

    private void OnDrawGizmos() //draws vertices in red
    {
        if (vertices == null) //stops error while in editor
        {
            return;
        }
        Gizmos.color = Color.red;
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], 0.1f);
        }
    }

    


}
*/

