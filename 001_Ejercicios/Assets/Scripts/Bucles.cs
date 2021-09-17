using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    float secundero = 0f;//No esta terminado.
    int aleatorio;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Reloj");

        int fail = 0;

        while (aleatorio != 5)
        {
            aleatorio = Random.Range(0, 2000);
            if (aleatorio == 5)
            {
                print("Ha salido el numero " + aleatorio);
                print("Ha llegado " + fail + " numero de veces");
                StopCoroutine("Reloj");
                print(("ha tardado: ") + secundero);
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

    IEnumerator Reloj()
    {
      
            while (true)
        {
            secundero++;
            yield return new WaitForSeconds(1f);
        }
    }
}
