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
        if(PosX <= 12)
        {
            initPos = OtherObject.transform.position;
            FinalPos = initPos + Destpos * Time.deltaTime * speed;
            OtherObject.transform.position = FinalPos;
        }
        float desp1X = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * desp1X * Time.deltaTime);
    }
}
