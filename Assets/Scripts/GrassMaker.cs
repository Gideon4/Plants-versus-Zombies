using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassMaker : MonoBehaviour
{
    public GameObject grass;

    void Start()
    {
        CreateGrass();
    }

    private void CreateGrass()
    {
        float grasssize = grass.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        for(int x=0; x<10; x++){
            for(int y=0; y<5; y++){
                GameObject newGrass = Instantiate(grass);
                newGrass.transform.position = new Vector3(grasssize * x, grasssize * y, 0);
            }
        }
    }
}
