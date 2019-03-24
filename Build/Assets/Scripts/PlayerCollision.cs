using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Playermovement movement;
    public GameObject restartlevel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            //Debug.Log("You lost :(");
        }
    }
}
