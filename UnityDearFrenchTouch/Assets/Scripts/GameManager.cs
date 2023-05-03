using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gridManagerPrefab;

    private GridManager gridManager;

    private void Start()
    {
        gridManager = Instantiate(gridManagerPrefab).GetComponent<GridManager>();
        gridManager.Initialize();
    }

    private void Update()
    {
        // Code à exécuter à chaque image
    }
}