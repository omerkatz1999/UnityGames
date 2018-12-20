using UnityEngine;

public class playerMovement : MonoBehaviour {


    public Rigidbody rb;

    public Transform player;

    public Transform end;



    public float ForwardForce = 1000f;

    public float SidewaysForce = 500f;


    // Update is called once per frame
    void FixedUpdate ()
    {
        // movement forward, const movment regardless of frame rate


        if (player.position.y > 0)
        {
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);


            if (Input.GetKey("d"))
            {
                rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }


            if (Input.GetKey("a"))
            {
                rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }


        }

        else
        {
            rb.useGravity = false;
            FindObjectOfType<GameManagerScript>().EndGame();

        }


        if( player.position.z >= end.position.z)
        {
            ForwardForce = 0;
        }


    }
}
