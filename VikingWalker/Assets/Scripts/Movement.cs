using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController playerController;

    // Start is called before the first frame update
    void Start()  
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 direction = transform.forward * v * 10 + transform.right * h * 10;
        playerController.SimpleMove(direction);
        Debug.Log("current speed = " + playerController.velocity.magnitude);
    }
}
