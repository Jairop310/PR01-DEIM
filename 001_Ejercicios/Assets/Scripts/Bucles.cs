using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    
    int aleatorio;

    // Start is called before the first frame update
    void Start()
    {
        int fail = 0;

        while (aleatorio != 5)
        {
            aleatorio = Random.Range(0, 500);
            if (aleatorio == 5)
            {
                print("Ha salido el numero " + aleatorio);
                print("Ha llegado " + fail + " numero de veces");
            }
            else
            {
                fail++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
