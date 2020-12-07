using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public PillarManager pillarPuzzle;
    public SimonSaysLogic simonSaysPuzzle;
    public GameObject cube;
    public GameObject pillarSpawnLocation;
    public GameObject simonSpawnLocation;
    private int pillarSpawnCount = 0;
    private int simonSpawnCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pillarPuzzle.solved ==  true)
        {
            if (pillarSpawnCount < 1)
            {
                spawnCube();
                pillarSpawnCount++;
                Debug.Log("Cube Spawned");
            }
        }
        if (simonSaysPuzzle.solved == true)
        {
            if (simonSpawnCount < 1)
            {
                spawnSimonCube();
                simonSpawnCount++;
                Debug.Log("Cube Spawned");
            }
        }
    }

    public void spawnCube()
    {
        if (pillarPuzzle.solved == true)
        {
            Instantiate(cube, pillarSpawnLocation.transform);
            pillarPuzzle.solved = false;
        }
    }

    public void spawnSimonCube()
    {
        if (simonSaysPuzzle.solved == true)
        {
            Instantiate(cube, simonSpawnLocation.transform);
            simonSaysPuzzle.solved = false;
        }
    }
}
