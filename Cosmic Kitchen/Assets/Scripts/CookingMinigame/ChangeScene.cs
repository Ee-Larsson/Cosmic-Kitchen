using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void GoToSceneTestMap()
    {
        print("CHANGING SCENE!");
        SceneManager.LoadScene("TestMap");
    }
}
