using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarScript : MonoBehaviour
{
    public GameObject Pillar;
    public GameObject PlayerHand;
  

    public bool solved;
    // Start is called before the first frame update
    void Start()
    {
        solved = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == Pillar.tag)
        {
            Debug.Log("COORECT SPHERE");
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.GetComponent<Collider>().enabled = false; // maybe?
            solved = true;
        }
        else
        {
            if (other.gameObject.tag != PlayerHand.tag)
            {
                Debug.Log("INCORRECT SPHERE " + Pillar.tag);
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
}
