using UnityEngine;

public class ActionScript : MonoBehaviour
{
    BoxCollider2D Box;
    [SerializeField] GameObject InteractionSymbol;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
