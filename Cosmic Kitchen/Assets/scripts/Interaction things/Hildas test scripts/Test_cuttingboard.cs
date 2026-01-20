using Assets.Scripts.Food_related;
using UnityEngine;

public class Test_cuttingboard : MonoBehaviour
{

    public TestMovement player;
    public CutScript cuttingBoard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Holding>().ReturnHolding().GetSpriteIndex() == 1)
        {
            gameObject.GetComponent<Holding>().PlaceFood();
            player.Cutting();
            cuttingBoard.BoardCutting();
        }
    }

    public void StopInteract()
    {
        gameObject.GetComponent<Holding>().AddFood(new Veggie("cut marstato", false, 4));
    }
}
