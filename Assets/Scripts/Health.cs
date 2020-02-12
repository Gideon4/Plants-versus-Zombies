using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    int currenthealth = 5;
    
    public void DoDamage(int n){
        currenthealth -= n;
        if(currenthealth <= 0){
            Destroy(gameObject);
        }
    }
}
