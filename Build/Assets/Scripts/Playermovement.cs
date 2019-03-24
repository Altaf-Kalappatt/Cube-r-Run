using UnityEngine;

public class Playermovement : MonoBehaviour
{

    //Initializing Rigidbody properties to rb of player
    public Rigidbody rb;

    public Transform player_y;

    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;

    // Use this for initialization


    // Update is called once per frame
    void FixedUpdate()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (player_y.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
