using UnityEngine;
using UnityEngine.UI;

public class GaneLogic : MonoBehaviour
{
    public Transform ConveyorBelt;
    public GameObject[] Fruits;
    public Vector3 startposition;
    Vector3 nextPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        for (int i=0;i<20;i++){ // loops and executes 20 times 
            startposition.x += 50f;
            Vector3 nextPosition = new Vector3(startposition.x, startposition.y, startposition.z);
            GameObject randomFruit = Fruits[Random.Range()]
            GameObject fruit = Instantiate(randomFruit, nextPosition, Quaternion.identity);
            fruit.transform.SetParent(ConveyorBelt, false);
        }*/
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    
    // Events Trigger functions - Button Click or DropDown or Slider or Collision or Keypress
    public void PressApple(){
        Debug.Log("APPLE"); // test button press
        startposition.x += 1f;
        Vector3 nextPosition = new Vector3(startposition.x, startposition.y, startposition.z);
        GameObject fruit = Instantiate(Fruits[0], nextPosition, Quaternion.identity);
        fruit.transform.SetParent(ConveyorBelt, false);
        //
        ConveyorBelt.position = new Vector3(ConveyorBelt.position.x - 1f, ConveyorBelt.position.y, ConveyorBelt.position.z);
    }
    public void PressLemon(){
        Debug.Log("LEMON"); // test button press
        startposition.x += 1f;
        Vector3 nextPosition = new Vector3(startposition.x, startposition.y, startposition.z);
        GameObject fruit = Instantiate(Fruits[1], nextPosition, Quaternion.identity);
        fruit.transform.SetParent(ConveyorBelt, false);
        //
        ConveyorBelt.position = new Vector3(ConveyorBelt.position.x - 1f, ConveyorBelt.position.y, ConveyorBelt.position.z);
    }
    public void PressWatermelon(){
        Debug.Log("WATERMELON"); // test button press
        startposition.x += 1f;
        Vector3 nextPosition = new Vector3(startposition.x, startposition.y, startposition.z);
        GameObject fruit = Instantiate(Fruits[2], nextPosition, Quaternion.identity);
        fruit.transform.SetParent(ConveyorBelt, false);
        //
        ConveyorBelt.position = new Vector3(ConveyorBelt.position.x - 1f, ConveyorBelt.position.y, ConveyorBelt.position.z);
    }
    public void PressBlueberry(){
        Debug.Log("BLUEBERRY"); // test button press
        startposition.x += 1f;
        Vector3 nextPosition = new Vector3(startposition.x, startposition.y, startposition.z);
        GameObject fruit = Instantiate(Fruits[3], nextPosition, Quaternion.identity);
        fruit.transform.SetParent(ConveyorBelt, false);
        //
        ConveyorBelt.position = new Vector3(ConveyorBelt.position.x - 1f, ConveyorBelt.position.y, ConveyorBelt.position.z);
    }
    public void PressOrange(){
        Debug.Log("ORANGE"); // test button press
        startposition.x += 1f;
        Vector3 nextPosition = new Vector3(startposition.x, startposition.y, startposition.z);
        GameObject fruit = Instantiate(Fruits[4], nextPosition, Quaternion.identity);
        fruit.transform.SetParent(ConveyorBelt, false);
        //
        ConveyorBelt.position = new Vector3(ConveyorBelt.position.x - 1f, ConveyorBelt.position.y, ConveyorBelt.position.z);
    }
}
