using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artefactManager : MonoBehaviour
{
    public bool isRelevant = true;
    public OverallManager om;

    

    //public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Sword")
        {
            if(isRelevant)
            {
                om.SlashedRelevant(transform.position + (transform.up * 2.0f));
            }

            else
            {
                om.SlashedIrrelevant(transform.position + (transform.up * 2.0f));
            }

            Destroy(gameObject);
        }
    }
}
