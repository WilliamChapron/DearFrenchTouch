using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public GameObject casePrefab;
    public Material defaultMaterial;
    public Material hoverMaterial;

    private GameObject[,] cases;
    private Renderer lastHoveredRenderer;

    void Start()
    {
        cases = new GameObject[width, height];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                GameObject newCase = Instantiate(casePrefab, new Vector3(i, 0, j), Quaternion.identity);
                newCase.GetComponent<Renderer>().material = defaultMaterial;
                cases[i, j] = newCase;
            }
        }
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Renderer renderer = hit.collider.GetComponent<Renderer>();
            if (renderer != null)
            {
                if (lastHoveredRenderer != null)
                {
                    lastHoveredRenderer.material = defaultMaterial;
                }
                renderer.material = hoverMaterial;
                lastHoveredRenderer = renderer;
            }
        }
        else if (lastHoveredRenderer != null)
        {
            lastHoveredRenderer.material = defaultMaterial;
            lastHoveredRenderer = null;
        }
    }
}