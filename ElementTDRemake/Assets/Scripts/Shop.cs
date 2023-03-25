using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncher;
	public TurretBlueprint laserBeamer;

	public TurretBlueprint fireTurret;
	public TurretBlueprint waterTurret;
	public TurretBlueprint earthTurret;
	public TurretBlueprint windTurret;

	BuildManager buildManager;

	void Start(){
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret (){
		buildManager.SelectTurretToBuild(standardTurret);
	}

	public void SelectMissileLauncher(){
		buildManager.SelectTurretToBuild(missileLauncher);
	}

	public void SelectLaserBeamer(){
		buildManager.SelectTurretToBuild(laserBeamer);
	}

	public void SelectFireTurret (){
		buildManager.SelectTurretToBuild(fireTurret);
	}

	public void SelectWaterTurret(){
		buildManager.SelectTurretToBuild(waterTurret);
	}

	public void SelectEarthTurret(){
		buildManager.SelectTurretToBuild(earthTurret);
	}

	public void SelectWindTurret (){
		buildManager.SelectTurretToBuild(windTurret);
	}

	public void UnlockFireElement(){
		PlayerStats.fireUnlocked = true;
		PlayerStats.Money -= 500;
		GameManager.instance.elementsUnlockedUI.transform.GetChild (0).gameObject.SetActive (true);
	}

	public void UnlockWaterElement(){
		PlayerStats.waterUnlocked = true;
		PlayerStats.Money -= 500;
		GameManager.instance.elementsUnlockedUI.transform.GetChild (1).gameObject.SetActive (true);
	}

	public void UnlockEarthElement(){
		PlayerStats.earthUnlocked = true;
		PlayerStats.Money -= 500;
		GameManager.instance.elementsUnlockedUI.transform.GetChild (2).gameObject.SetActive (true);
	}

	public void UnlockWindElement(){
		PlayerStats.windUnlocked = true;
		PlayerStats.Money -= 500;
		GameManager.instance.elementsUnlockedUI.transform.GetChild (3).gameObject.SetActive (true);
	}

}
