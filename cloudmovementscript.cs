using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudmovementscript : MonoBehaviour
{

    public float movespeed = 6;
    public float deadzone = -66;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Debug.Log("cloud deleted");
            Destroy(gameObject);
        }
    }
}
