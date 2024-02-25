using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float velocity = 1.0f;
    public float velocity_R_L = 2.0f;
    public FixedJoystick joystick;

    // Update is called once per frame
    void Update()
    {
        // velocity * Time.deltaTime *
        transform.position += new Vector3( velocity * Time.deltaTime , 0, - (joystick.Direction.x * velocity_R_L * Time.deltaTime));
        
    }
}
