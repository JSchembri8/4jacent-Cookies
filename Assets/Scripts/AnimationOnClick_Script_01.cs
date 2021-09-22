using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOnClick_Script_01 : MonoBehaviour
{
    Animator anim;
    Animator anim2;
    public bool twoStates;
    public bool isOpen = false; // Preparing for two-state animations
    public bool isCoroutineExecuting = false;
    public bool canFade = false;
    private Color alphaColor;
    private float timeToFade = 1.0f;
    Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        canFade = false;
        alphaColor = gameObject.GetComponent<Renderer>().material.color;
        alphaColor.a = 0;
        m_Collider = GetComponent<Collider>();
    }

    void Update()
    {
        if (canFade)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(gameObject.GetComponent<Renderer>().material.color, alphaColor, timeToFade * Time.deltaTime);
        }
    }
    // Update is called once per frame
    void OnMouseOver() 
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Opening");
            anim.SetTrigger("Active");
            StartCoroutine(ExecuteAfterTime(2f));
        }
       
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;
        m_Collider.enabled = false;


        yield return new WaitForSeconds(time);
        canFade = true;
        isCoroutineExecuting = false;
    }
}
