using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysButton : MonoBehaviour
{
    public GameObject PlayerHand;

    public Material lmat;
    public Material nMat;


    public int myNumber = 99;
    public SimonSaysLogic myLogic;

    public delegate void TriggerEvent(int number);

    public event TriggerEvent onTriggerEnter;
    //private Vector3 myTP;

    private Renderer myR;


    private void Awake()
    {
        myR = GetComponent<Renderer>();
        myR.enabled = true;
       // myTP = transform.position;
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == PlayerHand.tag)
        {
            ButtonPressed();
        }
      
    }
    public void ButtonPressed()
    {
        if (myLogic.player != true)
        {
            myR.material = lmat;
            onTriggerEnter.Invoke(myNumber);
            StartCoroutine(ColorChange());
        }
        else
        {
            myR.material = lmat;
            onTriggerEnter.Invoke(myNumber);
        }
            //myTP = new Vector3(-.2f, myTP.y, myTP.z);
    }

    private void OnTriggerExit(Collider other)
    {
        unButtonPressed();
    }
    public void unButtonPressed()
    {
      
            myR.material = nMat;
            //onTriggerEnter.Invoke(myNumber);
        
    }

    private IEnumerator ColorChange()
    {
        myR.material = lmat;
        yield return new WaitForSeconds(.5f);
    }
}
