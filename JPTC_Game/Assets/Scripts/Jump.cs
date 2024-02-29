using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // velocity * Time.deltaTime *
       
        transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
    }
    public void JumpOver(int jumpHeight){
        print("Jump");
        transform.position += new Vector3(0, jumpHeight * Time.deltaTime, 0);
    }

}
