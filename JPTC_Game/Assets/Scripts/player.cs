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
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(velocity * Time.deltaTime, 0, 0);
        
    }
}
