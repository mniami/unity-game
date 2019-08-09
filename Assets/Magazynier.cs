using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazynier : MonoBehaviour
{
    public GameObject cube;

    // Use this for initialization
    void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision otherObj)
    {
    }
    void LateUpdate()
    {
        if (Input.GetKey("q"))
        {
            Vector3 playerPos = transform.position;
            Vector3 playerDirection = transform.forward;
            Quaternion playerRotation = transform.rotation;
            float spawnDistance = 2;

            Vector3 spawnPos = playerPos + playerDirection * spawnDistance;

            cube.transform.position += transform.forward * Time.deltaTime;
           // cube.transform.rotation = transform.rotation;
        }
        else if (Input.GetKey("e"))
        {
            Vector3 playerPos = transform.position;
            Vector3 playerDirection = transform.forward;
            Quaternion playerRotation = transform.rotation;
            float spawnDistance = 2;

            Vector3 spawnPos = playerPos + playerDirection * spawnDistance;

            cube.transform.position = spawnPos;
            cube.transform.rotation = transform.rotation;
        }
        //Camera.main.transform.LookAt(cube.transform);
    }
}
