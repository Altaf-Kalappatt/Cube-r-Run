using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completelevelUI;
    public GameObject restartlevelUI;

    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
    }

    /*public void RestartLevel()
    {
        restartlevelUI.SetActive(true);
    }*/

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            //Invoke("Restart", restartDelay);
            restartlevelUI.SetActive(true);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
    
