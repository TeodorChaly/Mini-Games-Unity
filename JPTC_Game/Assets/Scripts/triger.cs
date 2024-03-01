using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger : MonoBehaviour
{
    
    private Animator doorAnimator;x
    void Start()
    {       
        doorAnimator = GameObject.Find("enemy_2").GetComponent<Animator>();
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name.Equals("Player")){
            print("Collider + " + other.gameObject.name);
            doorAnimator.SetBool("door_open", true);
        }
    }
    
    void Update()
    {
        
    }
}
