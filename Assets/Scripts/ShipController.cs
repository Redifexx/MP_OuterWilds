using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public Rigidbody cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            cube.AddForce(Vector3.up * 20f);
        }
    }
}
