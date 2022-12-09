using UnityEngine;

public class PlayerMove : MonoBehaviour
{ 
    
    public Rigidbody rb;
    public float forvardForse=600f;
    public float sideweyForse=500f;
    
    void Start()
    {
       //rb.AddForce(0,200,500);
        //rb.useGravity = false;
    }

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forvardForse * Time.deltaTime);
        if( Input.GetKey("d"))
        {
            rb.AddForce(sideweyForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-1 * sideweyForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameMeneger>().EndGame();
        }
    }
}
