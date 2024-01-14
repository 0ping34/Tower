using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[System.Serializable]
public class TurretBlueprint
{
    public GameObject prefab;
    public int cost;

    public GameObject upgradeprefab;
    public int upgradecost;

    public int GetSellAmount(bool isTurretUpgraded)
    {
        if (isTurretUpgraded)
        {
            
            return (upgradecost+cost) / 2; 
        }
        else
        {
            return cost / 2;
        }
    }

}
