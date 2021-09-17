using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    public int num1;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (num1 < 10)
        {
            num1++;
        }
        else
        {
            print("El Numero ha alcanzado 10");
        }
        
    }
}
