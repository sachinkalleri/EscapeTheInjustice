using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class OverallManager : MonoBehaviour
{
    AudioSource audioCue;

    public int spawnSize = 4;
    public int numberOfArtefacts = 4;
    public int occupiedCount = 0;
    public float xLimit = 50.0f, zLimit = 50.0f;

    public float cloakLevel = 10.0f;
    public bool isCloakLosing = false;

    Vector3 spawnLocation = Vector3.one;
    Vector3[] occupiedLocations = new Vector3[8];//{ new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f) };
    //public Transform[] occupiedLocations;


    //public GameObject cube;
    //public GameObject[] spawnLocations; To delete
    public GameObject[] artefacts;
    public GameObject infoObject;
    public GameObject spawnedObjects;
    public GameObject sword;
    public GameObject blindfold;
    public GameObject relevantDestroyFX;
    public GameObject irrelevantDestroyFX;

    public bool[] isDestroyed = new bool[] { false, false, false, false };
    bool isFirstSpawn = true;
    bool isSpawned = false;
    float timer = 5.0f;
    public int[] availableArtefacts = new int[] { -1, -1, -1, -1 };

    private InputDevice targetDevice;


    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        if(devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        occupiedLocations[0] = sword.transform.position;
        occupiedCount++;
        Debug.Log("Going to Spawn");
        Spawn();
        isCloakLosing = true;
    }


    // Update is called once per frame
    void Update()
    {
        occupiedLocations[0] = sword.transform.position;

        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        
        if (isSpawned)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                isSpawned = false;
                timer = 5.0f;
            }
        }

        if(primaryButtonValue && !isSpawned)
        {
            blindfold.SetActive(true);
            Spawn();
            playAudioCue();
            blindfold.SetActive(false);
            isSpawned = true;
        }

        targetDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonValue);

        if (secondaryButtonValue)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    //When the user slashes relevant artefacts
    public void SlashedRelevant(Vector3 artefactPosition)
    {
        Instantiate(relevantDestroyFX, artefactPosition, Quaternion.identity);
        Instantiate(infoObject, artefactPosition, Quaternion.identity);
        cloakLevel += 2.0f;
        Debug.Log("Points++");
    }

    //When the user slashes irrelevant artefacts
    public void SlashedIrrelevant(Vector3 artefactPosition)
    {
        Instantiate(irrelevantDestroyFX, artefactPosition, Quaternion.identity);
        Instantiate(infoObject, artefactPosition, Quaternion.identity);
        cloakLevel -= 1.0f;
        Debug.Log("Points--");
    }

    //Function to spawn, also used for rearrange the artefacts
    public void Spawn()
    {
        bool isColliding = true;        
        uint whileEscape;
        int liveArtefactCount;

        GameObject[] currObjects = new GameObject[8];

        if(!isFirstSpawn)
        {
            currObjects = GameObject.FindGameObjectsWithTag("Artefact");
            liveArtefactCount = currObjects.Count();
            spawnSize = liveArtefactCount;
            occupiedCount = liveArtefactCount + 1;
        }

        for (int i = 0; i < spawnSize; i++)
        {
            spawnLocation.x = Random.Range(0, xLimit);
            spawnLocation.z = Random.Range(0, zLimit);
            spawnLocation.y = 0.0f;

            whileEscape = 0;

            while (isColliding)
            {
                whileEscape++;

                for (int j = 0; j < occupiedCount; j++)
                {
                    if (InsideRegion(spawnLocation, occupiedLocations[j], 10.0f))
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

            if(isFirstSpawn)
            {
                int artefactTypeCount = artefacts.Count();
                int randomArtefactIndex = Random.Range(0, artefactTypeCount);

                //Debug.Log("Inside the for loop" +i);

                spawnedObjects = Instantiate(artefacts[randomArtefactIndex], spawnLocation, Quaternion.identity);
                spawnedObjects.tag = "Artefact";
                spawnedObjects.GetComponent<artefactManager>().om = gameObject.GetComponent<OverallManager>();

                //tempStore[tempStoreCount] = spawnedObject.transform.position;
                occupiedLocations[occupiedCount] = spawnLocation;
                occupiedCount++;
            }

            else
            {
                currObjects[i].transform.position = spawnLocation;        
            }
        }
        isFirstSpawn = false;
        Debug.Log("Done Spawning");

        if (isCloakLosing)
        {
            cloakLevel -= Time.deltaTime;
            if (cloakLevel <= 0.0f)
            {
                Debug.Log("Cloak ran out. You failed to escape the level");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    //To check if a point is in a circle
    public bool InsideRegion(Vector3 point, Vector3 regionCenter, float distanceLimit) 
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

    //To play the audio attached to artefacts if the artefact is a relevant one
    public void playAudioCue()
    {
        GameObject[] currObjects = new GameObject[8];
        int currObjectCount;

        currObjects = GameObject.FindGameObjectsWithTag("Artefact");

        currObjectCount = currObjects.Count();

        for(int i = 0; i < currObjectCount; i++)
        {
            if (currObjects[i].layer == 8)
            {
                audioCue = currObjects[i].GetComponent<AudioSource>();
                audioCue.Play();
            }
        }

    }
    
}