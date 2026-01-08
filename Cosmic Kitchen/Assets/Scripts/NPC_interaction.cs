using UnityEngine;

public class NPC_interaction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    BoxCollider2D collider;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player") == true)
        {

        }
    }
}
