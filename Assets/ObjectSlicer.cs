using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class ObjectSlicer : MonoBehaviour
{
    public float slicedObjectInitialVelocity = 100;
    public Material slicedMaterial;
    public Transform startSlicingPoint;
    public Transform endSlicingPoint;
    public LayerMask sliceableLayer;
    public VelocityEstimator velocityEstimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 slicingDirection = endSlicingPoint.position - startSlicingPoint.position;
        bool hasHit = Physics.Raycast(startSlicingPoint.position, slicingDirection, out hit, slicingDirection.magnitude, sliceableLayer);
        if(hasHit)
        {
            if (hit.transform.gameObject.layer == 9)
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            else
                Slice(hit.transform.gameObject,hit.point, velocityEstimator.GetVelocityEstimate());
        }
    }

    void Slice(GameObject target, Vector3 planePosition, Vector3 slicerVelocity)
    {
        Debug.Log("WE SLICE THE OBJECT");
        Vector3 slicingDirection = endSlicingPoint.position - startSlicingPoint.position;
        Vector3 planeNormal = Vector3.Cross(slicerVelocity, slicingDirection);

        SlicedHull hull = target.Slice(planePosition, planeNormal, slicedMaterial);

        if(hull != null)
        {
            //DisplayScore.score++;

            GameObject upperHull = hull.CreateUpperHull(target, slicedMaterial);
            GameObject lowerHull = hull.CreateLowerHull(target, slicedMaterial);

            CreateSlicedComponent(upperHull);
            CreateSlicedComponent(lowerHull);

            Destroy(target);
        }
    }

    void CreateSlicedComponent(GameObject slicedHull)
    {
        Rigidbody rb = slicedHull.AddComponent<Rigidbody>();
        MeshCollider collider = slicedHull.AddComponent<MeshCollider>();
        collider.convex = true;

        rb.AddExplosionForce(slicedObjectInitialVelocity, slicedHull.transform.position, 1);

        Destroy(slicedHull, 4);
    }
}
