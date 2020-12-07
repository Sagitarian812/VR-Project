using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonSaysLogic : MonoBehaviour
{

    public SimonSaysButton[] myButtons;
    public List<int> colorList;

    public float showTime = 1f;
    public float pauseTime = 0.5f;

    private int myRandom;
    public int level = 2;
    private int playerLevel = 0;

    public Button Startbutton;

    bool simon = false;
    public bool player = false;
    public bool solved = false;


    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i< myButtons.Length; i++)
        {
            myButtons[i].onTriggerEnter += ButtonPressed;
            myButtons[i].myNumber = i;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (simon)
        {
            simon = false;
            StartCoroutine(Simon());
        }
    }

    void ButtonPressed(int _number)
    {
        if(player)
        {
            if(_number == colorList[playerLevel])
            {
                playerLevel += 1;
            }
            else
            {
                GameOver();
            }
            if(playerLevel == level)
            {
                level += 1;
                playerLevel = 0;
                player = false;
                simon = true;
            }
            if (level ==5)
            {
                solved = true;
            }
        }
    }

    void GameOver()
    {
        Startbutton.interactable = true;
        player = false;
    }

   public void StartGame()
    {
        simon = true;
        playerLevel = 0;
        level = 2;
        Startbutton.interactable = false;
        Debug.Log("GAME STARTED");
    }

    public IEnumerator Simon()
    {
        for (int i = 0; i < level; i++)
        {
            if(colorList.Count < level)
            {
                myRandom = Random.Range(0, myButtons.Length);
                colorList.Add(myRandom);
            }
            myButtons[colorList[i]].ButtonPressed();

            yield return new WaitForSeconds(showTime);
            myButtons[colorList[i]].unButtonPressed();

            yield return new WaitForSeconds(pauseTime);
        }
        player = true;
    }
}
