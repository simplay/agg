using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rg;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Vector3 force = collision.collider.transform.position;

            // This completely ingores a player´s speed, which might feel weird.
            rg.AddForce(-force * 0.5f, ForceMode.Impulse);            
        }
    }
}
