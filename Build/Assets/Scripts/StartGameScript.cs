using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
