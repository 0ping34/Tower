using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NodeUI : MonoBehaviour
{
    public GameObject ui;

    private Node target;

    public Text upgradeCost;
    public Button upgradeButton;
    public Text SellCost;

    public void SetTarget(Node _target)
    { 
        target = _target;

        transform.position=target.GetBuildPosition();

        if(!target.isUpgraded)
        {
            upgradeCost.text = "UPGRADE \n" + "$" + target.turretBlueprint.upgradecost.ToString();
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "UPGRADE \n" + "MAX";
            upgradeButton.interactable= false;
        }

        bool isUpgraded=target.isUpgraded;
        SellCost.text = "SELL \n" + "$" + target.turretBlueprint.GetSellAmount(isUpgraded);

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Upgradeturret() 
    { 
     target.UpgradeTurret();
     BuildManager.instance.DeselectNode();
    }

    public void Sellturret()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
        target.isUpgraded = false;
    }
}
