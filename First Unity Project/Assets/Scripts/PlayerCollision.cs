using UnityEngine;

public class PlayerCollision : MonoBehaviour {


    public playerMovement movement;

    public Rigidbody playerRB;

    public Collider playerCollider;

    public bool grounded;

    private void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Obstacle")
        {

            if( GameObject.Find("ExtraLives").GetComponent<ExtraLife>().extraLivesCounter > 0)

            {

                GameObject.Find("ExtraLives").GetComponent<ExtraLife>().extraLivesCounter--;
                collisionInfo.collider.isTrigger = true;
                grounded = true;
                Debug.Log("here");

            }
            else
            {
                movement.enabled = false;


                FindObjectOfType<GameManagerScript>().EndGame();

            }

        }

        if( collisionInfo.collider.tag == "ground")
        {
            grounded = true;
            Debug.Log("true");

        }
      

    }


    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "ground")
        {
            grounded = false;
            Debug.Log("false");
        }
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Coin")
        {

            Destroy(other.gameObject);
            FindObjectOfType<CoinTracker>().AddCoin();


        }



        if (other.tag == "ExtraLife")
        {

            Destroy(other.gameObject);
            FindObjectOfType<ExtraLife>().AddCoin();


        }

        if (other.tag == "PhaseCoin")
        {

            Destroy(other.gameObject);
            playerRB.useGravity = false;
            playerCollider.isTrigger = true;
            FindObjectOfType<ChangeMaterial>().PhaseModeMaterial();
            Invoke("undoPhase", 3);

        }

    }


    private void undoPhase()
    {
        playerRB.useGravity = true;
        playerCollider.isTrigger = false;
    }



}

