using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

   

    public GameObject completeLevelUI;

    bool gameHasEnded = false;

    public float restartDelay = 4f;

    public void EndGame()
    {


        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Reset", restartDelay);
        }

    }

    void Reset()
    {
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
    }




}
