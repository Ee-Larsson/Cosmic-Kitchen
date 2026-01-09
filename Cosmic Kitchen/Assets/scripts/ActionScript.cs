using Unity.VisualScripting;
using UnityEngine;

public class ActionScript : MonoBehaviour
{
    [SerializeField] GameObject InteractionSymbol; 
    bool Colliding = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            InteractionSymbol.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, -1);
            Colliding = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            InteractionSymbol.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, 10);
            Colliding = false;
        }
    }
    public bool ReturnIfPlayerIsColiding()
    {
        return Colliding; // use bool colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
    }
}
