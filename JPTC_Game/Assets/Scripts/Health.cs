using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject health_item;
    public int inthealth = 10;
    private void OnCollisionEnter(Collision collision) {
        player playerScript = collision.gameObject.GetComponent<player>();
        playerScript.updateLife(inthealth);
        Destroy(health_item);
    }


}
