﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/* Class: VRSimulatorController
 * MonoBehaviour that can be attached to a gameobject to represent a simulated XR Controller.
 */
[DefaultExecutionOrder(100)]
public class VRSimulatorController : MonoBehaviour
{
#if UNITY_EDITOR || VRSim_include_in_build
    //Variable: offsetCompensation
    //Defines if an offset in world space should be considered in the simulation, otherwise the local position and rotation of the simulated controller will be the world space position and rotation of the XRController.
    [SerializeField]
    bool offsetCompensation = false;

    //Variable: offset
    //The Transform of the offset.
    [SerializeField]
    Transform offset = null;

    //Variable: left
    //Defines if the virtual controller is a left or right controller.
    [SerializeField]
    private bool left = false;

    Vector3 pos = Vector3.zero;
    Vector3 rot = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        rot = this.transform.localEulerAngles;
        pos = this.transform.position;
        if (offsetCompensation && offset)
        {
            pos = VectorHelper.RotatePointAroundPivot(pos, offset.position, -offset.eulerAngles.y * Vector3.up);
            pos = VectorHelper.RotatePointAroundPivot(pos, offset.position, -offset.eulerAngles.x * Vector3.right);
            pos = VectorHelper.RotatePointAroundPivot(pos, offset.position, -offset.eulerAngles.z * Vector3.forward);

            pos -= offset.position;
        }
        VRSimulatorInputInterface.SetControllerTransform(left, pos, Quaternion.Euler(rot));
    }
#endif
}
