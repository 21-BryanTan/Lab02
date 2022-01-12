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
        cube0.GetComponent<MeshRenderer>().material.color = Color.white;
        cube1.GetComponent<MeshRenderer>().material.color = Color.white;
        cube2.GetComponent<MeshRenderer>().material.color = Color.white;
        cube3.GetComponent<MeshRenderer>().material.color = Color.white;
        cube4.GetComponent<MeshRenderer>().material.color = Color.white;
        cube5.GetComponent<MeshRenderer>().material.color = Color.white;
        cube6.GetComponent<MeshRenderer>().material.color = Color.white;
        cube7.GetComponent<MeshRenderer>().material.color = Color.white;
        cube8.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        //Getting User Input//

        //1st Row//
        if(Input.GetKeyDown(KeyCode.Q))
        {
            //Check if Cube is White Color//
            if (cube0.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
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
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            //Check if Cube is White Color//
            if (cube1.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    cube1.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    cube1.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;
            }
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {

            //Check if Cube is White Color//
            if (cube2.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    cube2.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    cube2.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;
            } 
        }
        //2nd Row//
        if (Input.GetKeyDown(KeyCode.A))
        {

            //Check if Cube is White Color//
            if (cube3.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    cube3.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    cube3.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;
            }  
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {

            //Check if Cube is White Color//
            if (cube4.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    cube4.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    cube4.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;
            }          
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {

            //Check if Cube is White Color//
            if (cube5.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    cube5.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    cube5.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;
            }
        }
        //3rd Row//
        if (Input.GetKeyDown(KeyCode.Z))
        {

            //Check if Cube is White Color//
            if (cube6.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    cube6.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    cube6.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;
            }    
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {

            //Check if Cube is White Color//
            if (cube7.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    cube7.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    cube7.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;
            } 
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {

            //Check if Cube is White Color//
            if (cube8.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Check turnCounter for Even number//
                if (turnCounter % 2 == 0)
                {
                    print("Player 1 Turn");
                    cube8.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                else
                {
                    print("Player 2 Turn");
                    cube8.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                //increase the turn counter//
                turnCounter++;
            } 
        }
    }

    private void checkRedWinCondition()
    {
        //Horizontal Win Condition//
        if(cube0.GetComponent<MeshRenderer>().material.color == Color.red &&
           cube1.GetComponent<MeshRenderer>().material.color == Color.red &&
           cube2.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Wins the Game!");
        }
        else if(cube3.GetComponent<MeshRenderer>().material.color == Color.red &&
                cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
                cube5.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Wins the Game!");
        }
        else if (cube6.GetComponent<MeshRenderer>().material.color == Color.red &&
                 cube7.GetComponent<MeshRenderer>().material.color == Color.red &&
                 cube8.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Wins the Game!");
        }
        //Vertical Win Condition//
        if (cube0.GetComponent<MeshRenderer>().material.color == Color.red &&
           cube3.GetComponent<MeshRenderer>().material.color == Color.red &&
           cube6.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Wins the Game!");
        }
        else if (cube1.GetComponent<MeshRenderer>().material.color == Color.red &&
                cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
                cube7.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Wins the Game!");
        }
        else if (cube2.GetComponent<MeshRenderer>().material.color == Color.red &&
                 cube5.GetComponent<MeshRenderer>().material.color == Color.red &&
                 cube8.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Wins the Game!");
        }
        //Diagonal Win Condition//
        if (cube0.GetComponent<MeshRenderer>().material.color == Color.red &&
           cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
           cube8.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Wins the Game!");
        }
        else if (cube2.GetComponent<MeshRenderer>().material.color == Color.red &&
                cube4.GetComponent<MeshRenderer>().material.color == Color.red &&
                cube6.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            print("Red Player Wins the Game!");
        }
    }

}
