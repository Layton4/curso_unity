using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    //public int carDoors = 4;
    public int x = 2;
    public int y = 3;


    public int hour = 23;
    public float pi = 3.14f;
    public string game = "Objetivo cumplido";
    public bool spiderman = true;

    void Start()
    {
        //Debug.Log(3 + 5);
        //Debug.Log(carDoors - 3);
        AddTwoNumbers();
    }
    void Update()
    {
        
    }

    void AddTwoNumbers()
    {
        Debug.Log(x + y);
    }
}
