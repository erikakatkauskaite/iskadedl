using UnityEngine.SceneManagement;
using UnityEngine;

public class pergButtons : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene("skadedl");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
