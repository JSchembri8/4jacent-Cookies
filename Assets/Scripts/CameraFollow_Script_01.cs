using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow_Script_01 : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.z = player.transform.position.z;
        position.y = player.transform.position.y;
        transform.position = position;
    }
}
