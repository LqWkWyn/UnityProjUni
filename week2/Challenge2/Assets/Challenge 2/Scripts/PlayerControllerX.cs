using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cd = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cd <=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cd = 1;
        }
        if(cd >=0){
            cd -= Time.deltaTime;
        }
        
    }
}
