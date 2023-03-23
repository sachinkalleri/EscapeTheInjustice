using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < spawnSize; i++)
        {
            Instantiate(cube, spawnLocations[i].transform.position, Quaternion.identity);
        }
        
    }

    public int spawnSize = 4;
    public int numberOfArtefacts = 4;
    public GameObject cube;
    public GameObject[] spawnLocations;
    public GameObject[] artefacts;
    public bool[] isDestroyed = new bool[] { false, false, false, false };
    public int[] availableArtefacts = new int[] { -1, -1, -1, -1 };

    // Update is called once per frame
    void Update()
    {
        
    }
}
