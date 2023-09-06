using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectspawner : MonoBehaviour
{
    public GameObject objTospawn;
    private logic placementIndicator;
    // Start is called before the first frame update
    void Start()
    {
        placementIndicator = FindObjectOfType<logic>();
        objTospawn = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        { 
                // Ensure that a prefab is assigned to this variable
                if (objTospawn != null)
                {
                    Instantiate(objTospawn, placementIndicator.transform.position, placementIndicator.transform.rotation);
                }
        }
    }
    public void SetObjectToSpawn(GameObject objectToSpawn)
    {
        objTospawn = objectToSpawn;
    }
}
