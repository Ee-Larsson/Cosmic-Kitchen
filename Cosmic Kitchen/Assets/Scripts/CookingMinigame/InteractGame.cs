using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractGame : MonoBehaviour
{
    bool isIngridient1;
    bool isIngridient2;

    public int maxProgress;
    public int currentProgress;

    public ProgressBar progressbar;

    public GameObject Ingridient1;
    public GameObject Ingridient2;
    public GameObject Food;

    public TextMeshProUGUI text;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isIngridient1 = false;
        isIngridient2 = false;

        Food.SetActive(false);
        text.enabled = false;

        maxProgress = 100;
        currentProgress = 0;

        progressbar.SetMaxProgress(maxProgress);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isIngridient1 && isIngridient2)
        {
            text.enabled = true;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                MakeProgress(20);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.name == "EGG")
        {
            print("Egg inside!");
            isIngridient1 = true;
        }

        if (collision.name == "WHEAT")
        {
            print("Wheat inside!");
            isIngridient2 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "EGG")
        {
            print("Egg outside!");
            isIngridient1 = false;
        }

        if (collision.name == "WHEAT")
        {
            print("Wheat outside!");
            isIngridient2 = false;
        }
    }

    void MakeProgress(int progress)
    {
        if (currentProgress < maxProgress)
        {
            currentProgress += progress;

            progressbar.setProgress(currentProgress);
        }
        else
        {
            Ingridient1.SetActive(false);
            Ingridient2.SetActive(false);

            Food.SetActive(true);
            text.enabled = false;
        }
    }

}
