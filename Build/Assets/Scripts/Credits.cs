using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("WHYYYYYYYYYYYYYYYY?");
        Application.Quit();
    }

    public void Restart()
    {
        Debug.Log("Thank Lord!");
        SceneManager.LoadScene(0);
    }
}
