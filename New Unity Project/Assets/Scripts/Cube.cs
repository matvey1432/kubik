using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameMeneger gameMeneger;
    void OnTriggerEnter()
    {
        gameMeneger.CompleteLevel();
    }

}
