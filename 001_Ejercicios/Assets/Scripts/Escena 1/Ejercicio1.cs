using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public int num1;
    public int num2;
    private int resultado;
    public string texto;
    bool Alive;



    // Start is called before the first frame update
    void Start()
    {

        resultado = (num1 + num2);



        texto = ("El resultado es " + resultado);
        print(texto);


        if (resultado >= 100)
        {
            print("El resultado es mayor o igual que 100");
            Alive = false;
        }
        else
        {
            print("El resultado es menor que 100");
            Alive = true;
        }

        if (Alive = true)
        {
            print("El jugador esta muerto");
        }
        else
        {
            print("El jugador esta vivo");
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}

