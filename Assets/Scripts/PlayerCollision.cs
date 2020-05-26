using UnityEngine;
using UnityEngine.AI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioSource Crash;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Crash.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
