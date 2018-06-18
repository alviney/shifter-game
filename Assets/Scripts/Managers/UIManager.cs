using UnityEngine;

public class UIManager : MonoBehaviour {

	public void	LoadLevel(string levelName) {
		GameManager.instance.LoadLevel(levelName);
	}

	public void LoadMenu() {
		GameManager.instance.LoadMenu();
	}

	public void ReloadLevel() {
		GameManager.instance.ReloadLevel();
	}
}
