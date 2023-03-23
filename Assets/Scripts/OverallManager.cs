using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OverallManager : MonoBehaviour
{
    public int spawnSize = 4;
    public int numberOfArtefacts = 4;
    public int occupiedCount = 0;
    public float xLimit = 50.0f, zLimit = 50.0f;

    Vector3 spawnLocation = Vector3.one;
    Vector3[] occupiedLocations = new Vector3[8];//{ new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f) };
    //public Transform[] occupiedLocations;


    public GameObject cube;
    //public GameObject[] spawnLocations; To delete
    public GameObject[] artefacts;
    public GameObject infoObject;
    public GameObject spawnedObject;
    public GameObject sword;

    public bool[] isDestroyed = new bool[] { false, false, false, false };
    public int[] availableArtefacts = new int[] { -1, -1, -1, -1 };

    // Start is called before the first frame update
    void Start()
    {
        occupiedLocations[0] = sword.transform.position;
        occupiedCount++;
        Debug.Log("Going to Spawn");
        Spawn();
    }


    // Update is called once per frame
    void Update()
    {
        occupiedLocations[0] = sword.transform.position;
    }

    public void SlashedRelevant(Vector3 artefactPosition)
    {
        Instantiate(infoObject, artefactPosition, Quaternion.identity);
        Debug.Log("Points++");
    }

    public void SlashedIrrelevant(Vector3 artefactPosition)
    {
        Instantiate(infoObject, artefactPosition, Quaternion.identity);
        Debug.Log("Points--");
    }

    public void Spawn()
    {
        bool isColliding = true;
        uint whileEscape;


        for (int i = 0; i < spawnSize; i++)
        {
            spawnLocation.x = Random.Range(0, xLimit);
            spawnLocation.z = Random.Range(0, zLimit);
            spawnLocation.y = 10.0f;

            whileEscape = 0;

            while (isColliding)
            {
                whileEscape++;

                for (int j = 0; j < occupiedCount; j++)
                {
                    if (insideRegion(spawnLocation, occupiedLocations[j], 10.0f))
                    {
                        isColliding = true;
                        break;
                    }

                    else
                    {
                        if (j == occupiedCount - 1)
                        {
                            isColliding = false;
                        }
                    }
                }
                if (isColliding)
                {
                    spawnLocation.x = Random.Range(-xLimit, xLimit);
                    spawnLocation.z = Random.Range(-zLimit, zLimit);
                }

                if (whileEscape >= 100)
                {
                    Debug.Log("Exiting infinity while loop");
                    break;
                }
            }

            int artefactTypeCount = artefacts.Count();
            int randomArtefactIndex = Random.Range(0, artefactTypeCount);

            //Debug.Log("Inside the for loop" +i);

            spawnedObject = Instantiate(artefacts[randomArtefactIndex], spawnLocation, Quaternion.identity);
            spawnedObject.GetComponent<artefactManager>().om = gameObject.GetComponent<OverallManager>();

            //tempStore[tempStoreCount] = spawnedObject.transform.position;
            occupiedLocations[occupiedCount] = spawnLocation;
            occupiedCount++;
        }
        Debug.Log("Done Spawning");
    }

    public bool insideRegion(Vector3 point, Vector3 regionCenter, float distanceLimit) //To check if a point is in a circle
    {
        Vector3 pointTested;
        Vector3 centre;

        pointTested = point;
        centre = regionCenter;

        pointTested.y = 0;
        centre.y = 0;

        float distance = Vector3.Distance(pointTested, centre);

        if (distance <= distanceLimit)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}