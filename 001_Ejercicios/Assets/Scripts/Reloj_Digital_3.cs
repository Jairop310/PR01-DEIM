using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj_Digital_3 : MonoBehaviour
{
    // Start is called before the first frame update
    //Variables con los contadores
    int segundos;
    int minutos;
    int horas;
    string textoFinal;
    // Start is called before the first frame update
    void Start()
    {
        //Ponemos los contadores a 0
        segundos = 0;
        minutos = 0;
        horas = 0;
        //Llamamos a la corrutina que se ejecutará cada segundo
        StartCoroutine("clockStart");
    }
    //No tenemos función update
    IEnumerator clockStart()
    {
        //Usamos el for para sumar un segundo en cada ciclo
        for (; ; segundos++)
        {
            //Si superamos el minuto
            if (segundos > 59)
            {
                minutos++;
                segundos = 0; //Ponemos los segundos a 0
            }
            //Creamos una variable string que contiene los segundos
            //Usamos el método ToString, pasando un parámetro
            string segundosSt = segundos.ToString("D2");
            //Si llegamos a la hora
            if (minutos > 59)
            {
                horas++;
                minutos = 0;
            }
            //Variable string con los minutos y horas con 2 dígitos
            string minutesSt = minutos.ToString("D2");
            string horasSt = horas.ToString();
            //Creamos el texto final, para mostrar
            textoFinal = horasSt + ":" + minutesSt + ":" + segundosSt;
            print(textoFinal);
            yield return new WaitForSeconds(1f);
        }
    }
}