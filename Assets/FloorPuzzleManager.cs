using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPuzzleManager : MonoBehaviour
{
    public FloorButton button1;
    public FloorButton button2;
    public FloorButton button3;
    public GameObject door;
    // Update is called once per frame
    void Update()
    {
        if( button1.buttonPressed && button2.buttonPressed && button3.buttonPressed ==true)
        {
            Debug.Log("DOOR OPEN");
            door.GetComponent<Transform>().position = new Vector3(door.transform.position.x, -10f, door.transform.position.z);
        }
    }
}
