using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public Vector2 flap = new Vector2(0, 10);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ehe");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            birdBody.velocity = Vector2.up * flap;
        }
    }
}
