using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBasics_Script_01 : MonoBehaviour
{
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(key.GetComponent<Collected_Script_01>().showInventory == true)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
