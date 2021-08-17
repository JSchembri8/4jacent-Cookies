using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOnClick_Script_01 : MonoBehaviour
{
    Animator anim;
    public bool twoStates;
    public bool isOpen = false; // Preparing for two-state animations
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseOver() 
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Opening");
            anim.SetTrigger("Active");
        }
       
    }
}
