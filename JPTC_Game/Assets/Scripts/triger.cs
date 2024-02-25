using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger : MonoBehaviour
{
    
    private Animator doorAnimator;
    // Start is called before the first frame update
    void Start()
    {       
        doorAnimator = GameObject.Find("enemy_2").GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other) {
        // print("Collider + " + other.gameObject.name);
        if (other.gameObject.name.Equals("Cube")){
            print("Collider + " + other.gameObject.name);
            doorAnimator.SetBool("StarDoorAnim", true);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
