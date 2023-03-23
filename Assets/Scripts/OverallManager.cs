using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class OverallManager : MonoBehaviour
{
    AudioSource audioCue;

    public int spawnSize = 10;
    public int occupiedCount = 0;
    public float xLimit = 50.0f, zLimit = 50.0f;
    public int whistleOptions = 3;

    public float blindfoldTimer = 2.0f;
    bool isBlindfolded = false;

    public float cloakLevel = 30.0f;
    public bool isCloakLosing = false;

    Vector3 spawnLocation = Vector3.one;
    Vector3[] occupiedLocations = new Vector3[15];

    public Material green;
    public Material red;

    public GameObject[] artefacts;
    public GameObject infoObject;
    public GameObject spawnedObjects;
    public GameObject sword;
    public GameObject blindfold;
    public GameObject relevantDestroyFX;
    public GameObject irrelevantDestroyFX;
    public GameObject winBoard;
    public GameObject failBoard;

    bool gameWon = false;
    bool gameLost = false;
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

        if(checkWin() && !gameLost)
        {
            Debug.Log("You won the level");
            isCloakLosing = false;
            gameWon = true;
            winBoard.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(whistleOptions < 0)
        {
            whistleOptions = 0;
        }

        if (whistleOptions > 3)
        {
            whistleOptions = 3;
        }

        if (isSpawned)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                isSpawned = false;
                timer = 5.0f;
            }
        }

        if((primaryButtonValue && !isSpawned && whistleOptions > 0))
        {
            whistleOptions--;
            Debug.Log("Whistle options left:" + whistleOptions);
            blindfold.SetActive(true);
            isBlindfolded = true;
            Spawn();
            playAudioCue();
            //blindfold.SetActive(false);
            isSpawned = true;            
        }

        if(isBlindfolded)
        {
            blindfoldTimer -= Time.deltaTime;
            if(blindfoldTimer <= 0.0f)
            {
                blindfold.SetActive(false);
                isBlindfolded = false;
                blindfoldTimer = 2.0f;
            }
        }

        targetDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonValue);

        if (secondaryButtonValue)
        {
            if(gameWon || gameLost)
            {
                winBoard.SetActive(false);
                failBoard.SetActive(false);
                gameWon = false;
                gameLost = false;
                isCloakLosing = true;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (isCloakLosing)
        {
            cloakLevel -= Time.deltaTime;

            if (cloakLevel <= 0.0f && !gameWon)
            {
                Debug.Log("Cloak ran out. You failed to escape the level");
                failBoard.SetActive(true);
                gameLost = true;
                isCloakLosing = false;
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        else
        {
            if(!gameWon && !gameLost)
            {
                isCloakLosing = true;
            }
        }
    }

    //When the user slashes relevant artefacts
    public void SlashedRelevant(Vector3 artefactPosition)
    {
        GameObject infoObjectTemp;
        Instantiate(relevantDestroyFX, artefactPosition, Quaternion.identity);
        infoObjectTemp = Instantiate(infoObject, artefactPosition, Quaternion.identity);
        infoObjectTemp.GetComponent<MeshRenderer>().material = green;
        cloakLevel += 5.0f;
        if(whistleOptions < 3)
        {
            whistleOptions++;
        }
        //Debug.Log("Points++");
    }

    //When the user slashes irrelevant artefacts
    public void SlashedIrrelevant(Vector3 artefactPosition)
    {
        GameObject infoObjectTemp;
        Instantiate(irrelevantDestroyFX, artefactPosition, Quaternion.identity);
        infoObjectTemp = Instantiate(infoObject, artefactPosition, Quaternion.identity);
        infoObjectTemp.GetComponent<MeshRenderer>().material = red;
        cloakLevel -= 3.0f;
        //Debug.Log("Points--");
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

            while (isColliding) //This while loop makes sure that the randomized position is not colliding with other objects
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

                spawnedObjects = Instantiate(artefacts[randomArtefactIndex], spawnLocation, Quaternion.identity);
                spawnedObjects.tag = "Artefact";
                spawnedObjects.GetComponent<artefactManager>().om = gameObject.GetComponent<OverallManager>();

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
    }

    //To check if a point is in a region
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

    public bool checkWin()
    {
        bool isWin = true;
        GameObject[] currObjects = new GameObject[8];
        int currObjectCount;

        currObjects = GameObject.FindGameObjectsWithTag("Artefact");

        currObjectCount = currObjects.Count();

        for (int i = 0; i < currObjectCount; i++)
        {
            if(currObjects[i].layer == 8)
            {
                isWin = false;
                break;
            }
        }

        return isWin;
    }
    
}