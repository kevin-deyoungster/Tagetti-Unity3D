﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotationSpeed = 100;

    public GameObject bulletPrefab;
    
	void Update () {

        //Rotate Along the Z - Axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime); 

        //On Space Press Shoot Ball
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && FindObjectOfType<GameManager>().gamePaused == false)
        {
            Shoot();
        }
	}

    void Shoot()
    {
        GetComponent<AudioSource>().Play();
        Transform shootPoint = transform.GetChild(0).transform;
        Instantiate(bulletPrefab, shootPoint.position, shootPoint.transform.rotation);
    }
}
