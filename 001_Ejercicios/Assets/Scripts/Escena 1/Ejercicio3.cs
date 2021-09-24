using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    int vidas;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 10;

        //Obtengo el resultado de llamara al metodo y actño en consecuencia
        if (EsPar(vidas) == true) //Cuando pasamos una booleana a un if no es necesario el ==
        {
            print("Es par");
        }
        else
        {
            print("Es impar");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool EsPar(int numero)
    {
        bool esNumeroPar;

        //Comprobar si es par ("%" devuelve el no de decimales si divido por 2
        if (numero % 2 == 0)
        {
            esNumeroPar = true;
        }
        else
        {
            esNumeroPar = false;
        }

        return esNumeroPar;
    }
}

