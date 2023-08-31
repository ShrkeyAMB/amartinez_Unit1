using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 acceleration;
    public float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);

        

        GatherInput();

        transform.Translate(acceleration);
    }

    

    void GatherInput()
    {
        acceleration = Vector3.forward * Time.deltaTime * speed;
    }

    
}
