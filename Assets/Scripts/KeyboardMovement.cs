using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    public float speed = 3.0f;

    /*  
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A and D
        float vertical = Input.GetAxis("Vertical"); // W and S

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * speed * Time.deltaTime, Space.Self);
    }
}
