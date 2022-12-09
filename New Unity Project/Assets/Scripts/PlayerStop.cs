using UnityEngine;

public class PlayerStop : MonoBehaviour
{
    public PlayerMove movement;
   
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Stoper")
        {
            movement.enabled = false;
            FindObjectOfType<GameMeneger>().EndGame();
        }
    }

}
