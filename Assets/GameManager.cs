using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool ended = false;

	public void GameOver() {
		if (ended == false) {
			ended = true;
			Restart();
			FindObjectOfType<ForLoosersToWatch>().ShowAd();
		}
	}
	
	void Restart () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
