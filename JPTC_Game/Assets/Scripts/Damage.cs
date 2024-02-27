using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int intdamage = 5;
    private void OnCollisionEnter(Collision collision) {
        player playerScript = collision.gameObject.GetComponent<player>();
        playerScript.updateLife(intdamage);
    }
}
