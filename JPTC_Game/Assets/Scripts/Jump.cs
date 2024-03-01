using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
       
        transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
    }
    public void JumpOver(int jumpHeight){
        transform.position += new Vector3(0, jumpHeight * Time.deltaTime, 0);
    }

}
