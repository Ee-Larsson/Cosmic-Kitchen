using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Image BAM;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BAM.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            BAM.enabled = true;
        }
        else
        {
            BAM.enabled = false;
        }

    }

}

