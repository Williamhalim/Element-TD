using UnityEngine;

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
		
}
