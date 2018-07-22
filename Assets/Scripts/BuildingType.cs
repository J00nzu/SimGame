using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingType", menuName = "ScriptableObject/BuildingType", order = 1)]
public class BuildingType : ScriptableObject {

    public GameObject building;
    public int buildCost;
    public int buildTime;
}
