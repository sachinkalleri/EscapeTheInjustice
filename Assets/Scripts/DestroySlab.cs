using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySlab : MonoBehaviour
{
    public GameObject infoText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {        
        if(other.tag == "Sword")
        {
            Destroy(infoText);
        }
    }
}
