using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigScore : MonoBehaviour
{
    public doLojiks lojik;

    // Start is called before the first frame update
    void Start()
    {
        lojik = GameObject.FindGameObjectWithTag("lojik").GetComponent<doLojiks>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        { lojik.addScore(); }
    }
}
