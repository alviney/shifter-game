using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

#region 
	private void Awake() {

		if (instance == null)

			instance = this;

		else if (instance != this) 
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject); 
	}
#endregion

	public void	LoadLevel(string levelName) {
		SceneManager.LoadScene(levelName);
	}

	public void LoadMenu() {
		SceneManager.LoadScene("00_Menu");
	}

	public void ReloadLevel() {
		Scene scene = SceneManager.GetActiveScene(); 
		SceneManager.LoadScene(scene.name);
	}
}
