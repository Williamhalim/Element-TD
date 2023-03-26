using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}

	public GameObject buildEffect;
	public GameObject sellEffect;

	private TurretBlueprint turretToBuild;
	private Node selectedNode;

	public NodeUIBuild nodeUIBuild;
	public NodeUIUpgrade nodeUIUpgrade;

	[Header("For Inspector")]
	public Button fireTurretButton;
	public Button waterTurretButton;
	public Button earthTurretButton;	
	public Button windTurretButton;
	public Button metalTurretButton;
	public Button lightningTurretButton;
	public Button woodTurretButton;
	public Button iceTurretButton;

	public void SelectNode (Node node)
	{
		if (selectedNode == node)
		{
			DeselectNode();
			return;
		}
		selectedNode = node;
		nodeUIBuild.SetTarget(node);
	}

	public void DeselectNode()
	{
		selectedNode = null;
		nodeUIBuild.Hide();
	}

	public void SelectTurretToBuild (TurretBlueprint turret){
		turretToBuild = turret;
		selectedNode.BuildTurret(turretToBuild);
		DeselectNode ();
	}

	public TurretBlueprint GetTurretToBuild(){
		return turretToBuild;
	}

	public void UnlockFireButton() {
		fireTurretButton.interactable = true;
	}
	public void UnlockWaterButton()
	{
		waterTurretButton.interactable = true;
	}
	public void UnlockEarthButton()
	{
		earthTurretButton.interactable = true;
	}
	public void UnlockWindButton()
	{
		windTurretButton.interactable = true;
	}

	public void UnlockMetalButton()
	{
		metalTurretButton.interactable = true;
	}
	public void UnlockLightningButton()
	{
		lightningTurretButton.interactable = true;
	}
	public void UnlockWoodButton()
	{
		woodTurretButton.interactable = true;
	}
	public void UnlockIceButton()
	{
		iceTurretButton.interactable = true;
	}

}
