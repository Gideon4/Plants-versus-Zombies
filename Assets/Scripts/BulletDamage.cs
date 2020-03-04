using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll){
        if(coll.tag == "zombie"){
            coll.GetComponent<Health>().DoDamage(1);
            Destroy(gameObject);
        }
    }
}
