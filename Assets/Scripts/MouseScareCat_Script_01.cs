using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScareCat_Script_01 : MonoBehaviour
{
    public bool startMoving = false;
    public GameObject endPos;
    public Vector3 moveTo;
    public Vector3 startPos;
    public GameObject catPaw;
    public GameObject catPaw2;
    public GameObject catPaw3;
    public GameObject windUp;
    public GameObject wheelOne;
    public GameObject wheelTwo;
    public bool isCoroutineExecuting = false;

    void Start()
    {
        moveTo = endPos.transform.position;
        startPos = transform.position;
    }
    void Update()
    {
        if (startMoving)
        {
            transform.Translate(0, 0, -10 * Time.deltaTime);
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startMoving = true;
            StartCoroutine(ExecuteAfterTime(8f));
            windUp.GetComponent<Animator>().enabled = true;
            wheelOne.GetComponent<Animator>().enabled = true;
            wheelTwo.GetComponent<Animator>().enabled = true;
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;


        yield return new WaitForSeconds(time);
        catPaw.SetActive(false);
        catPaw2.GetComponent<Collider>().enabled = false;
        catPaw3.SetActive(false);
        isCoroutineExecuting = false;
    }
}
