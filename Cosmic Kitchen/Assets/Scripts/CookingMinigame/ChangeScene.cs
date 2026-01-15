using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image fade;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void GoToSceneTestMap()
    {
        fade.GetComponent<Animator>().Play("FadeAnim");
        //SceneManager.LoadScene("TestMap");
    }
}
