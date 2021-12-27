using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    //public int carDoors = 4;
    public int x = 2;
    public int y = 3;
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
