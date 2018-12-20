using UnityEngine;
using UnityEngine.UI;

public class ExtraLife : MonoBehaviour {



    public Text extraLifeText;

    public float extraLivesCounter;


	// Update is called once per frame
    void Update () {

     
        extraLifeText.text = extraLivesCounter.ToString("0");
    }

    public void AddCoin()
    {

        extraLivesCounter++;
    }


}
