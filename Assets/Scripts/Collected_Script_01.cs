using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collected_Script_01 : MonoBehaviour
{
    public bool collectedStatus = false;
    public bool showInventory = false;
    public GameObject[] objectsToDelete;
    public bool additionalObjects = false;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {

            collectedStatus = true;
            showInventory = true;
            gameObject.GetComponent<Renderer>().enabled = false;
            if (additionalObjects)
            {
                foreach(GameObject obja in objectsToDelete)
                {
                    obja.SetActive(false);
                }
            }
        }
    }
}
