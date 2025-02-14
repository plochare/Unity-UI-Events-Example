using UnityEngine;

public class CollectibleState : MonoBehaviour
{
    public int IDnumber;
    public Material colorMat;
    public Material[] colorPallete;
    public string gameState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameState = "Blue";
    }

    public void ChangeState(){
        // Toggle Color
    }

    public string GetGameState(){
        return gameState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
