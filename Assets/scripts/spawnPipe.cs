using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipe : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            Instantiate(pipes, transform.position, transform.rotation);
        }
    }
}
