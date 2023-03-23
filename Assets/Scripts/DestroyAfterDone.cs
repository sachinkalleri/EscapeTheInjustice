using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDone : MonoBehaviour
{
    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= 5.0f)
        {
            Destroy(gameObject);
        }
    }
}
