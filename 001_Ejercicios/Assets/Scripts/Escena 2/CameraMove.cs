using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoverCamara();
    }
    void MoverCamara()
    {
        float newX = playerObject.transform.position.x;
        float newY = playerObject.transform.position.y;
        float newZ = transform.position.z;
        transform.LookAt(player);
        transform.position = new Vector3(newX, newY, newZ);  

    }
    
}
