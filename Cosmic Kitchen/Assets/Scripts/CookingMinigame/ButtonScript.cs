using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject BAM;
    public GameObject fade;

    Collider2D col;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BAM.SetActive(false);
        fade.SetActive(false);

        col = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnMouseDown()
    {
        fade.SetActive(true);
        //fade.GetComponent<Animator>().Play("FadeAnim");
        
    }

    public void ChangeScene()
    {
        print("YES!");
        //SceneManager.LoadScene("TestMap");
    }

    private void OnMouseOver()
    {
        BAM.SetActive(true);
    }

    private void OnMouseExit()
    {
        BAM.SetActive(false);
    }
}

