using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        Saludar("Jairo", 19);
        Saludar("Milena", 22);
        Saludar("Noe", 21);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Saludar(string name, int edad)
    {
        print("Hola " + name + "tu edad es " + edad + " años");
    }
}

