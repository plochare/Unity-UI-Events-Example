using UnityEngine;

public class MouseClickObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create ray from mouse click
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) // Check if ray hits something
            {
                GameObject objectHit = hit.collider.gameObject; // Get the object that was hit
                // Perform actions based on the hit object
                if (objectHit.name == "Sphere"){
                    Debug.Log("SPHERE CLICK");
                }
                if (objectHit.tag == "Colectible"){
                    // Make Collectible dissappear
                    Destroy(objectHit);
                }
            }
        }

    }
}
