using UnityEngine;
using UnityEngine.UI;

public class Hexgrid : MonoBehaviour
{

    public GameObject mountainPre;
    public GameObject tree;
    public GameObject mountainPrefab;
    public int width = 1;
    public int height = 1;

    public Color defaultColor = Color.white;

    public HexCell cellPrefab;
    public Text cellLabelPrefab;

    HexCell[] cells;

    Canvas gridCanvas;
    HexMesh hexMesh;

    void Awake()
    {
        gridCanvas = GetComponentInChildren<Canvas>();
        hexMesh = GetComponentInChildren<HexMesh>();

        cells = new HexCell[height * width];

        for (int z = 0, i = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                CreateCell(x, z, i++);
            }
        }
    }

    void Start()
    {
        hexMesh.Triangulate(cells);
        for (int i = 1; i <= 7; i++)
        {
            GameObject cube = Instantiate(mountainPre, transform.position, Quaternion.identity) as GameObject;
            cube.transform.position = new Vector3(Random.Range(-80, -17), -0.1f, Random.Range(-30, 70));
            cube.transform.localScale = new Vector3(Random.Range(1, 2), Random.Range(1, 2), Random.Range(1, 2));
        }
        hexMesh.Triangulate(cells);
        for (int i = 1; i <= 3; i++)
        {
            GameObject cube2 = Instantiate(mountainPrefab, transform.position, Quaternion.identity) as GameObject;
            cube2.transform.position = new Vector3(Random.Range(7, 46), -0.1f, Random.Range(-15, 40));
            cube2.transform.localScale = new Vector3(Random.Range(1, 2), Random.Range(1, 2), Random.Range(1, 2));
        }
        for (int i = 1; i <= 16; i++)
        {
            GameObject cube3 = Instantiate(tree, tree.transform.position, Quaternion.identity) as GameObject;
            tree.transform.position = new Vector3(Random.Range(-30, 40), -0.1f, Random.Range(-17, 30));
            tree.transform.localScale = new Vector3(Random.Range(1, 2), Random.Range(1, 2), Random.Range(1, 2));
        }
    }

    public void ColorCell(Vector3 position, Color color)
    {
        position = transform.InverseTransformPoint(position);
        HexCoordinates coordinates = HexCoordinates.FromPosition(position);
        int index = coordinates.X + coordinates.Z * width + coordinates.Z / 2;
        HexCell cell = cells[index];
        cell.color = color;
        hexMesh.Triangulate(cells);
    }

    void CreateCell(int x, int z, int i)
    {

        Vector3 position;
        position.x = (x + z * 0.5f - z / 2) * (HexMetrics.innerRadius * 2f);
        position.y = 0f;
        position.z = z * (HexMetrics.outerRadius * 1.5f);

        HexCell cell = cells[i] = Instantiate<HexCell>(cellPrefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = position;
        cell.coordinates = HexCoordinates.FromOffsetCoordinates(x, z);
        cell.color = defaultColor;
      
            }
}