using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarManager : MonoBehaviour
{
    public PillarScript Water;
    public PillarScript Earth;
    public PillarScript Air;
    public PillarScript Fire;

    public bool solved = false;

    // Update is called once per frame
    void Update()
    {
        if (Water.solved && Earth.solved && Air.solved && Fire.solved == true)
        {
            solved = true;
            Debug.Log("Puzzle Solved");
            return;
        }
    }
}
