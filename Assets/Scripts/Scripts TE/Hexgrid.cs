using UnityEngine;
using UnityEngine.UI;

/*Used the tutorial catLikeCoding for the map generation part of this VR falconry simulator
The URL - http://catlikecoding.com/unity/tutorials/hex-map-1/*/

public class Hexgrid : MonoBehaviour
{

    public GameObject mountainPre;//game objects to spwan in
    public GameObject tree;
    public GameObject mountainPrefab;
    public GameObject mapedge;
    public GameObject mapedge1;
    public int width = 1;
    public int height = 1;//grid defined in unity as it is public

    public Color defaultColor = Color.white;

    public HexCell cellPrefab;
    public Text cellLabelPrefab;

    HexCell[] cells;

    Canvas gridCanvas; //for the canvas not needed
    HexMesh hexMesh;

    void Awake()
    {
        gridCanvas = GetComponentInChildren<Canvas>(); //for canvas
        hexMesh = GetComponentInChildren<HexMesh>();//retrieving mesh

        cells = new HexCell[height * width];

        for (int z = 0, i = 0; z < height; z++)//goes through the itterations to creates cells
        {
            for (int x = 0; x < width; x++)
            {
                CreateCell(x, z, i++);
            }
        }
    }

    void Start()
    {
        /*this section is where the in game objects are spawned*/
        hexMesh.Triangulate(cells);//once grid is up uses mesh to triangulate cells
        for (int i = 1; i <= 20; i++)
        {
            GameObject cube = Instantiate(mountainPre, transform.position, Quaternion.identity) as GameObject;
            cube.transform.position = new Vector3(Random.Range(-5, 450), -0.1f, Random.Range(0, 270));
            cube.transform.localScale = new Vector3(Random.Range(1, 2), Random.Range(1, 2), Random.Range(1, 2));
        }
        for (int i = 1; i <= 15; i++)
        {
            GameObject cube2 = Instantiate(mountainPrefab, transform.position, Quaternion.identity) as GameObject;
            cube2.transform.position = new Vector3(Random.Range(-30, 400), -0.1f, Random.Range(0, 280));
            cube2.transform.localScale = new Vector3(Random.Range(1, 2), Random.Range(1, 2), Random.Range(1, 2));
        }
        for (int i = 1; i <= 100; i++)
        {
            GameObject cube3 = Instantiate(tree, tree.transform.position, Quaternion.identity) as GameObject;
            tree.transform.position = new Vector3(Random.Range(-10, 450), -0.1f, Random.Range(20, 230));
            tree.transform.localScale = new Vector3(Random.Range(1, 2), Random.Range(1, 2), Random.Range(1, 2));
        }
        for (int i = 1; i <= 100; i++)
        {
            GameObject cube4 = Instantiate(mapedge, mapedge.transform.position, Quaternion.identity) as GameObject;
            mapedge.transform.position = new Vector3(Random.Range(-30, 450), -0.5f, Random.Range(-20, -16));
            mapedge.transform.localScale = new Vector3(Random.Range(1, 4), Random.Range(1, 4), Random.Range(1, 4));
        }
        for (int i = 1; i <= 60; i++)
        {
            GameObject cube5 = Instantiate(mapedge1, mapedge1.transform.position, Quaternion.identity) as GameObject;
            mapedge1.transform.position = new Vector3(Random.Range(-30, 450), -0.7f, Random.Range(-29, -18));
            mapedge1.transform.localScale = new Vector3(Random.Range(2, 3), Random.Range(2, 3), Random.Range(2, 3));
        }
        for (int i = 1; i <= 150; i++)
        {
            GameObject cube4 = Instantiate(mapedge, mapedge.transform.position, Quaternion.identity) as GameObject;
            mapedge.transform.position = new Vector3(Random.Range(-40, -35), -0.5f, Random.Range(-20, 350));
            mapedge.transform.localScale = new Vector3(Random.Range(1, 4), Random.Range(1, 4), Random.Range(1, 4));
        }
        for (int i = 1; i <= 150; i++)
        {
            GameObject cube4 = Instantiate(mapedge, mapedge.transform.position, Quaternion.identity) as GameObject;
            mapedge.transform.position = new Vector3(Random.Range(-10, 450), -0.1f, Random.Range(240, 248));
            mapedge.transform.localScale = new Vector3(Random.Range(1, 4), Random.Range(1, 4), Random.Range(1, 4));
        }
        for (int i = 1; i <= 60; i++)
        {
            GameObject cube5 = Instantiate(mapedge1, mapedge1.transform.position, Quaternion.identity) as GameObject;
            mapedge1.transform.position = new Vector3(Random.Range(-10, 450), -0.1f, Random.Range(240, 248));
            mapedge1.transform.localScale = new Vector3(Random.Range(2, 3), Random.Range(2, 3), Random.Range(2, 3));
        }
        for (int i = 1; i <= 150; i++)
        {
            GameObject cube4 = Instantiate(mapedge, mapedge.transform.position, Quaternion.identity) as GameObject;
            mapedge.transform.position = new Vector3(Random.Range(415, 420), -0.1f, Random.Range(-20, 248));
            mapedge.transform.localScale = new Vector3(Random.Range(1, 4), Random.Range(1, 4), Random.Range(1, 4));
        }
    }

    public void ColorCell(Vector3 position, Color color)
    {
        position = transform.InverseTransformPoint(position);
        HexCoordinates coordinates = HexCoordinates.FromPosition(position);
        int index = coordinates.X + coordinates.Z * width + coordinates.Z / 2;
        HexCell cell = cells[index];
        //cell.color = color;
        hexMesh.Triangulate(cells);
    }

    void CreateCell(int x, int z, int i)
    {

        Vector3 position; 
        position.x = (x + z * 0.5f - z / 2) * (HexMetrics.innerRadius * 2f); //adjusting the distance between each cell so they fit
        position.y = 0f;
        position.z = z * (HexMetrics.outerRadius * 1.5f);

        HexCell cell = cells[i] = Instantiate<HexCell>(cellPrefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = position;
        cell.coordinates = HexCoordinates.FromOffsetCoordinates(x, z);
        //cell.color = defaultColor;
      
            }
}