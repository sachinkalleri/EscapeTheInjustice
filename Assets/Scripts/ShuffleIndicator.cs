using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShuffleIndicator : MonoBehaviour
{
    public OverallManager ovrMan;

    public GameObject[] image = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < ovrMan.whistleOptions; i++)
        {
            image[i].SetActive(true);
        }

        for(int i = ovrMan.whistleOptions; i < 3; i++)
        {
            image[i].SetActive(false);
        }
    }
}
