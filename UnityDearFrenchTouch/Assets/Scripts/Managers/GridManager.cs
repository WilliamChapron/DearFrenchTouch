using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int width = 2;
    public int height = 2;
    public GameObject casePrefab;

    private GridCase[,] cases;

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        cases = new GridCase[width, height];
        Vector3 terrainPos = GameObject.Find("Terrain").transform.position;

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector3 casePos = new Vector3(terrainPos.x + i, terrainPos.y, terrainPos.z + j);
                GameObject newCaseObject = Instantiate(casePrefab, casePos, Quaternion.identity);
                GridCase newCase = newCaseObject.GetComponent<GridCase>();
                cases[i, j] = newCase;
            }
        }
    }
}