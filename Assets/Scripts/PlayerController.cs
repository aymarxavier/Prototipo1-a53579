using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //Mover o veiculo para frente

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //viramos o veiculo
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
