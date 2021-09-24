using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 cubePos = new Vector3(0f, 0f, 0f);
    public float speed = 0f;



    // Start is called before the first frame update
    void Start()
    {
        speed = 5f ;
        transform.position = cubePos;
    }

    // Update is called once per frame
    void Update()
    {
        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");
        float desplF = Input.GetAxis("Profundidad+");
        

        transform.Translate(Vector3.right * Time.deltaTime * speed * desplH);
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplV);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * desplF);
       


        
        /*
        Vector3 destPos = new Vector3(-1f,1f,0);
        cubePos = cubePos + destPos * Time.deltaTime * speed;
        transform.position = cubePos;
        */
    }
}
