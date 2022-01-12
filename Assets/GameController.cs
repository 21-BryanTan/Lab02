using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject cube0;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    public GameObject cube7;
    public GameObject cube8;

    private int turnCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Getting User Input//
        //1st Row//
        if(Input.GetKeyDown(KeyCode.Q))
        {
            //Check turnCounter for Even number//
            if(turnCounter % 2 == 0)
            {
                print("Player 1 Turn");
                cube0.GetComponent<MeshRenderer>().material.color = Color.red;
            }
            else
            {
                print("Player 2 Turn");
                cube0.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            //increase the turn counter//
            turnCounter++;
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            turnCounter++;
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            turnCounter++;
        }
        //2nd Row//
        if (Input.GetKeyDown(KeyCode.A))
        {
            turnCounter++;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            turnCounter++;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            turnCounter++;
        }
        //3rd Row//
        if (Input.GetKeyDown(KeyCode.Z))
        {
            turnCounter++;
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            turnCounter++;
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            turnCounter++;
        }
    }
}
