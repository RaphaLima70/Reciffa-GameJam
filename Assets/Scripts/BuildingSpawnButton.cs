using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BuildingSpawnButton : MonoBehaviour
{
    BuildingManager buildingManager;

    public int buildingId;
    SlotType slot;
    public GameObject legenda;

    // Start is called before the first frame update
    void Start()
    {
        buildingManager = GameObject.FindObjectOfType<BuildingManager>();
        GetComponent<Button>().onClick.AddListener(Spawn);
    }
    void Spawn()
    {
        buildingManager.Criar(buildingId);
    }


}
