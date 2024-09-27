using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;  // Prefab bullet
    public Transform firePoint;      // bullet spawn point
    public float bulletSpeed = 20f;  // bullet speed
    public float bulletLifeTime = 2f;  // bulet life time

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))  // LMB to shoot
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // create bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       

        // bullet speed set
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;  // bullet throw

        // bullet destroy
        Destroy(bullet, bulletLifeTime);
    }
}