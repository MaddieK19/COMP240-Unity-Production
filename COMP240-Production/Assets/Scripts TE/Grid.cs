using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


//up to "We now have a mesh in play mode, but it doesn't show up yet because we haven't given it any triangles. Triangles are defined via an array of vertex indices. As each triangle has three points, three consecutive indices describe one triangle. Let's start with just one triangle."


/*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
