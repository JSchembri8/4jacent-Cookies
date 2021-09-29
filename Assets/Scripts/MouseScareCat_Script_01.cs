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
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;


        yield return new WaitForSeconds(time);
        catPaw.GetComponent<Renderer>().enabled = false;
        catPaw.GetComponent<Collider>().enabled = false;
        isCoroutineExecuting = false;
    }
}
