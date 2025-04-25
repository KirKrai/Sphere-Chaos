using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{



    public GameObject target;

    void Start()
    {
        //target = GameObject.Find("Player");
    }

    
    void Update()
    {

        //1 вариант
        //float xMove = Input.GetAxis("Horizontal") * .5f;
        //float yMove = Input.GetAxis("Vertical") * .5f;
        //transform.Translate(xMove, 0f, yMove);

        //2 вариант с мышкой
        transform.Translate(Input.GetAxis("Horizontal") * 0.1f, 0f, Input.GetAxis("Vertical") * 0.1f);

       // target.transform.Rotate(Input.GetAxis("Mouse Y") * 3f, Input.GetAxis("Mouse X") * 3f, 0f);





    }
}
