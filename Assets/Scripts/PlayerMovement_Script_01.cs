using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement_Script_01 : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 direction;
    public float speed = 8;

    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        float hInput = Input.GetAxis("Horizontal");
        direction.z = hInput * speed;
        controller.Move(direction * Time.deltaTime);

        // Quit Game
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene("Greybox_12Aug_v1");
        }

    }
}
