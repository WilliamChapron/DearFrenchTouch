using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gridManagerPrefab;
    public GameObject buildManagerPrefab;

    private GridManager gridManager;
    private BuildManager buildManager;

    private void Start()
    {
        gridManager = Instantiate(gridManagerPrefab).GetComponent<GridManager>();
        gridManager.Initialize();
        buildManager = Instantiate(buildManagerPrefab).GetComponent<BuildManager>();
    }

    private void Update()
    {
        // Code à exécuter à chaque image
    }
}