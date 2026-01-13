using Unity.VisualScripting;
using UnityEngine;

public class playerActionScript : MonoBehaviour
{
    bool Colliding = false;
    GameObject CollisionObject = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interactible") == true)
        {
            Colliding = true;
            CollisionObject = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interactible") == true)
        {
            Colliding = false;
            CollisionObject = null;
        }
    }
    public bool ReturnIfPlayerIsColiding()
    {
        return Colliding; // use bool colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
    }
    public GameObject ReturnCollidingObject()
    {
        return CollisionObject;
    }
}
