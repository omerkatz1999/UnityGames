using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;

    public Transform end;

    public Text scoreText;
	
	// Update is called once per frame
	void Update () {

        if (player.position.y > 0)
        {
            scoreText.text = player.position.z.ToString("0");
        }

        if (player.position.z >= end.position.z)
        {
            scoreText.text = "You Won";

           
            FindObjectOfType<GameManagerScript>().LevelComplete();

        }



    }
}
