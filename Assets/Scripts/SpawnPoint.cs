using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private BuildingManager buildingManager;

    public SlotType slot;

    // Start is called before the first frame update
    void Start()
    {
        buildingManager = FindObjectOfType<BuildingManager>();
    }
    
    //função para identificar clique no objeto de spawn
    public void OnMouseDown()
    {
        buildingManager.OnSpawnPointSelected(this);
    }
}
