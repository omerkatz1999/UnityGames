using UnityEngine;
using UnityEngine.UI;

public class CoinTracker : MonoBehaviour {

    public Text coinTracker;

    public Rigidbody rb;

    public Transform player;

    public float numOfCoins;

    private bool jumpedOnce = false;

  
	// Update is called once per frame
	void Update () {

        coinTracker.text = numOfCoins.ToString("0");
        

	}


    public void AddCoin(){

        numOfCoins++;
    }

    private void JumpedOnceIsFalse()
    {
        jumpedOnce = false;
    }

    public void FixedUpdate()
    {

        bool isGrounded;
       isGrounded =  FindObjectOfType<PlayerCollision>().grounded;


        //jumping
        if ((Input.GetKey(KeyCode.UpArrow)|| Input.GetKey("w")) && numOfCoins >=1 &!(jumpedOnce) 
            && isGrounded && player.position.x > -10 && player.position.x < 10)
        {
            numOfCoins--;

            rb.AddForce(0, 700 * Time.deltaTime,0, ForceMode.VelocityChange);

            jumpedOnce = true;

            Invoke("JumpedOnceIsFalse", 1);

        }
    }
}
