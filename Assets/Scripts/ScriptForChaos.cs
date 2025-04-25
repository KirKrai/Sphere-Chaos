using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForChaos : MonoBehaviour
{
    public float startSpeed = 50f; 
    void Start()
    {
        Rigidbody rigidbody=GetComponent<Rigidbody>();
        rigidbody.linearVelocity=new Vector3(startSpeed,0,startSpeed);
        
    }

   
    void Update()
    {
        
    }
}
