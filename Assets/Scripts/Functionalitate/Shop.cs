using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileTurret;
    public TurretBlueprint laserTurret;

    BuildManager buildManager;

    private void Start()
    {
        buildManager =BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Turret Selectat");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Selectat");
        buildManager.SelectTurretToBuild(missileTurret);
    }

    public void SelectLaserLauncher()
    {
        Debug.Log("Laser Selectat");
        buildManager.SelectTurretToBuild(laserTurret);
    }
}
