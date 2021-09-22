using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor_Script_03 : MonoBehaviour
{
    public GameObject[] keyItems;
    public bool keysCollected = false;
  

    void Update()
    {
        if (keysCollected)
        {
            gameObject.SetActive(false);
        }
        keysCollected = AllKeysCollected();
    }

    private bool AllKeysCollected()
    {
        for (int g = 0; g < keyItems.Length; g++)
        {
            if (keyItems[g].GetComponent<LightColour_Script_1>().collectedStatus == false)
            {
                return false;
            }
        }
        return true;
    }
    
}
