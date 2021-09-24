using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_2 : MonoBehaviour
{
    [SerializeField] GameObject OtherObject;
    [SerializeField] float speed = 5f;
    private Vector3 initPos;
    [SerializeField] Vector3 Destpos;
    private Vector3 FinalPos;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float PosX = OtherObject.transform.position.x;

        float desp1Y = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * desp1Y * Time.deltaTime);
        float desp1X = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * desp1X * Time.deltaTime);
        float desp1Z = Input.GetAxis("Profundidad") * speed;
        transform.Translate(Vector3.forward * desp1Z * Time.deltaTime);
    }
}
