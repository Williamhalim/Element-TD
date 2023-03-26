using UnityEngine;
using UnityEngine.UI;

public class NodeUIUpgrade : MonoBehaviour {

	public GameObject ui;
	public Button upgradeButton;

	public Text sellAmount;

	private Node target;

	public void SetTarget (Node _target)
	{
		target = _target;

		transform.position = target.GetBuildPosition();

		if (!target.isUpgraded)
		{
			upgradeButton.interactable = true;
		} else
		{
			upgradeButton.interactable = false;
		}

		sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();
		Debug.Log(ui.name);
		ui.SetActive(true);
	}

	public void Hide ()
	{
		ui.SetActive(false);
	}

	public void Build(){
		
	}

	public void Upgrade ()
	{
		target.UpgradeTurret();
		BuildManager.instance.DeselectNode();
	}

	public void Sell ()
	{
		target.SellTurret();
		BuildManager.instance.DeselectNode();
	}

}
