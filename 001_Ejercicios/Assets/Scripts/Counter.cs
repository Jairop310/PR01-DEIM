using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] Text MyText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Cronometro()
    {
        for(int n =0; n <= 100; n++)
        {
            MyText.text = "Contador: " + n;
            yield return new WaitForSeconds(1f);
            if(n == 9)
            {
                StopCoroutine("Cronometro");
            }
        }
    }

}
