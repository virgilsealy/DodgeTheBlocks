using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float slowDownFactor = 10;

	public void EndGame () {
        StartCoroutine(RestartLevel());
	}

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowDownFactor;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDownFactor;

        yield return new WaitForSeconds(1f / slowDownFactor);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDownFactor;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
