using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel : MonoBehaviour
{
    
    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
