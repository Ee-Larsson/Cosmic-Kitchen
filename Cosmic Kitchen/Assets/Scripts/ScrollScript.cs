using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    public float speed;

    public Renderer bgRenderer;

    // Update is called once per frame
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
