using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int width = 2;
    public int height = 2;
    public GameObject casePrefab;

    private GameObject[,] cases;

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        cases = new GameObject[width, height];
        Vector3 terrainPos = GameObject.Find("Terrain").transform.position;

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector3 casePos = new Vector3(terrainPos.x + i, terrainPos.y, terrainPos.z + j);
                GameObject newCase = Instantiate(casePrefab, casePos, Quaternion.identity);
                cases[i, j] = newCase;
            }
        }
    }

    void Update()
    {
        
    }
}