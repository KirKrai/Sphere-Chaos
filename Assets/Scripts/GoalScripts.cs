using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScripts : MonoBehaviour
{
   public bool isSolved=false;

    void OnTriggerEnter(Collider collider)
    {
        GameObject collederWith = collider.gameObject;
        if (collederWith.tag==gameObject.tag) {
        
        isSolved=true;
            GetComponent<Light>().enabled = false;
            Destroy(collederWith);

        
        }
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
