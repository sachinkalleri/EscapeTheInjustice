using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + camera.forward);
    }
}
