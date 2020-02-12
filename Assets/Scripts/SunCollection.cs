using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCollection : MonoBehaviour
{
    public static int score = 100;

    void OnMouseDown(){
        score += 25;
        Destroy(gameObject);
    }
}
