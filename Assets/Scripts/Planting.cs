using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planting : MonoBehaviour
{
    void OnMouseUpAsButton(){
        if(BuildMenu.currentplant != null){
            Instantiate(BuildMenu.currentplant.gameObject,transform.position,Quaternion.identity);
            SunCollection.score -= BuildMenu.currentplant.price;
            BuildMenu.currentplant = null;
        }
    }
}
