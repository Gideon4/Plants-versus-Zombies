using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject bulletprefab;
    public float shootinginterval = 0.5f;

    void Start()
    {
        InvokeRepeating("shoot",0,shootinginterval);
    }

    void shoot(){
        if(zombieinfront()){
            GetComponent<Animator>().SetTrigger("isfiring");
            Instantiate(bulletprefab,transform.position,Quaternion.identity);
        }
    }

    bool zombieinfront(){
        Vector2 origin = new Vector2(9.5f,transform.position.y);
        RaycastHit2D[] hits = Physics2D.RaycastAll(origin,-Vector2.right);

        foreach(RaycastHit2D hit in hits){
            if(hit.collider != null && hit.collider.gameObject.tag == "zombie"){
                return true;
            }
        }
        return false;
    }
}
