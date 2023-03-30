using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;

        // Movimiento vertical
        float verticalInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0f, 0f, verticalInput) * speed * Time.deltaTime;
    }
}
