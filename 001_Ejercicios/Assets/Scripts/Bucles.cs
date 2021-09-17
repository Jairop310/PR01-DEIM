using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    public int num1;
    
    // Start is called before the first frame update
    void Start()
    {
        num1 = 1;
        while(num1 <= 10)
        {
            if (num1 < 5)
            {
                print("el numero es menor que 5");
            }
            else if (num1 >=5 && num1 <= 10)
            {
                print("El numero es " + num1);
            }
            else
            {
                print("El numero es 10");
            }
            num1++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
