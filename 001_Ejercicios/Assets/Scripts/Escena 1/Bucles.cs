using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{

    float secundero = 0f;//No esta terminado.
    int aleatorio;
    int nice;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Reloj");

        int fail = 0;

        while (aleatorio != 5)
        {
            aleatorio = Random.Range(0, 1000);
            if (aleatorio == 5)
            {
                print("Ha salido el numero " + aleatorio);
                print("ha fallado" + fail);
                StopCoroutine("Reloj");
                print(("ha tardado: ") + secundero);
                print("Han sido " + nice + " nice");
            }
            else if(aleatorio == 69)
            {
                nice++;
                fail++;
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
