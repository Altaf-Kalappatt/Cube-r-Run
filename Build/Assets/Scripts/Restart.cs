using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Debug.Log("WHYYYYYYYYYYYYYYYY?");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Debug.Log("Choose an option");
    }
}
