using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorButton : MonoBehaviour
{
    public bool buttonPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Puzzle Key")
        {
            buttonPressed = true;
            Debug.Log("BUTTON PRESSED");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Puzzle Key")
        {
            buttonPressed = false;
        }
    }
}
