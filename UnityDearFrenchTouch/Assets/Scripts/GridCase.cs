using UnityEngine;

public class GridCase : MonoBehaviour
{
    public Material defaultMaterial;
    public Material hoverMaterial;
    private Renderer renderer;
    private BuildManager buildManager;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = defaultMaterial;
        buildManager = FindObjectOfType<BuildManager>();
    }

    void OnMouseEnter()
    {
        renderer.material = hoverMaterial;
    }

    void OnMouseExit()
    {
        renderer.material = defaultMaterial;
    }

    private void OnMouseDown()
    {
        buildManager.BuildBuilding(transform.position);
    }
}