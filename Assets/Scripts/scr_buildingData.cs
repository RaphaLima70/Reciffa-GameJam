using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "BuildingData", menuName = "BuildingData", order = 1)]
public class scr_buildingData : ScriptableObject
{
    public Building[] buildings;    
}

[Serializable]
public class Building
{
    public string nome;
    public int custo;
    public SlotType slot;
    public GameObject prefab;
    public Sprite img;
    public float tempoDeConstrucao;


}

public enum SlotType
{
    Plano,
    Praia
}
