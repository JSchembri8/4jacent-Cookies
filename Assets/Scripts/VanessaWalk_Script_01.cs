using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanessaWalk_Script_01 : MonoBehaviour
{
    public GameObject vanessaIdle;
    public GameObject vanessaWalk;
    public bool isWalking = false;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            vanessaWalk.transform.rotation = Quaternion.Euler(0,180,0);
            vanessaIdle.GetComponent<Renderer>().enabled = false;
            vanessaWalk.SetActive(true);
        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            vanessaWalk.transform.rotation = Quaternion.Euler(0, 0, 0);
            vanessaIdle.GetComponent<Renderer>().enabled = false;
            vanessaWalk.SetActive(true);
        }
        else
        {
            vanessaWalk.SetActive(false);
            vanessaIdle.GetComponent<Renderer>().enabled = true;
        }
    }

}
