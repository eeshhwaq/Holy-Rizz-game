using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipey : MonoBehaviour
{
    public float movespeed=8;
    public float deadzone = -45;
 
    // Update is called once per frame
    void Update()
    { 
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("pipe deelted");
            Destroy(gameObject);
        }
    }
}
