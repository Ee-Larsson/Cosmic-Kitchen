using UnityEngine;

public class ActionScript : MonoBehaviour
{
    [SerializeField] GameObject InteractionSymbol; //share the same object between all the interactable 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            InteractionSymbol.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+1, -1);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            InteractionSymbol.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, 10);
        }
    }
}
