using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventsLogic : MonoBehaviour
{
    // Basic Unity Prototyping involves:
    // Connecting Events --> GameObjects --> Scripting Functions

    // Create Public Variables to expose GameObjects, UI Components, Prefabs and Properties
    public GameObject playerObj;
    public Renderer playerRenderer; 
    public Vector3 currentLocation;

    public Slider scaleSlider;
    public TMP_Dropdown colorDropdown;

    // Public Array of Custom Materials
    public Material[] colorPalette; 

    // Frame Events 
    void Start(){
        // Set Initial Position
        playerObj.transform.position = currentLocation;

    }
    void Update(){
        // Update every screen refresh
    }
    void FixedUpdate(){
        // Update on the set frame rate
        currentLocation.y += 0.01f ; // increment y value by 0.001
        playerObj.transform.position = new Vector3(currentLocation.x, currentLocation.y, scaleSlider.value);
    }

    // Create Public Functions to change or modify Properties
    public void SetPlayerScale(){
        playerObj.transform.localScale = new Vector3(scaleSlider.value, scaleSlider.value, scaleSlider.value);
    }

    public void SetPlayerColor(){
        playerRenderer.material = colorPalette[colorDropdown.value];
    }

    public void SetPlayerPosition(){
        playerObj.transform.position = new Vector3(currentLocation.x, currentLocation.y, scaleSlider.value);
    }
}
