using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class Reloj_Digital : MonoBehaviour
{
    DateTime Tiempo;
    [SerializeField] Text Segundos;
    [SerializeField] Text Minutos;
    [SerializeField] Text Horas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo = DateTime.Now;
        Horas.text = Tiempo.Hour.ToString();
        Minutos.text = Tiempo.Minute.ToString();
        Segundos.text = Tiempo.Second.ToString();
    }
}
