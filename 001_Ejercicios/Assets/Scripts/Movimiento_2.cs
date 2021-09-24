using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_2 : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float desp1Y = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * desp1Y * Time.deltaTime);
        float desp1X = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * desp1X * Time.deltaTime);
    }
}
