using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor_Script_01 : MonoBehaviour
{
    public GameObject[] keyItems;
    public bool keysCollected = false;
    public GameObject keyObject;
  

    void Update()
    {
        if (keysCollected)
        {
            gameObject.SetActive(false);
        }
        Debug.Log(keysCollected);
        keysCollected = AllKeysCollected();
    }

    private bool AllKeysCollected()
    {
        for (int g = 0; g < keyItems.Length; g++)
        {
            if (keyItems[g].GetComponent<Collected_Script_01>().collectedStatus == false)
            {
                return false;
            }
        }
        return true;
    }
    
}
