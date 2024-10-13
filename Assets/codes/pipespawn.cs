using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public GameObject ps;
    public float srate = 2;
    private float timer = 0;
    public float height=4; 
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < srate)
            timer += Time.deltaTime;
        else
        {
            spawnpipe();
            timer = 0;   }
    }
void spawnpipe()
    {
        
        float lowestpoint = transform.position.y - height;
        float highpoint = transform.position.y + height;
        Instantiate(ps, new Vector3(transform.position.x, Random.Range(lowestpoint, highpoint), 0), transform.rotation);

    }
}
