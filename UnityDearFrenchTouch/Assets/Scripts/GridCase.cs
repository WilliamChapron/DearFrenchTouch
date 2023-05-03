using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCase : MonoBehaviour
{
    public Material defaultMaterial;
    public Material hoverMaterial;

    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        base.renderer.material = defaultMaterial;
    }

    void OnMouseEnter()
    {
        base.renderer.material = hoverMaterial;
    }

    void OnMouseExit()
    {
        base.renderer.material = defaultMaterial;
    }
}