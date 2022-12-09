using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMeneger : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDispay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

   public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDispay);
        }
       
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
