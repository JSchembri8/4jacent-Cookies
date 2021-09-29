using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePickup_Script_1 : MonoBehaviour
{
    public GameObject[] keyItems;
    public bool keysCollected = false;

    void Update()
    {
        if (keysCollected)
        {
            gameObject.GetComponent<Collider>().enabled = true;
        }
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
