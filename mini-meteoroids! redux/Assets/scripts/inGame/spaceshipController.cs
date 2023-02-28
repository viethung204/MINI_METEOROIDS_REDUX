using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipController : MonoBehaviour
{
    Rigidbody2D rgbody;
    //Vector3 rotate;
    public float speed;
    public float torque;
    public float limit;

    public GameObject bulletPrefab;
    public Transform bulletSpawnpoint;
    float cooldown = 0.25f;
    public float bulletThrust;

    Animator shipAnimator;

    public AudioSource pew;

    bool right;
    bool left;

    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
        shipAnimator = GetComponent<Animator>();

    }

    private void Update()
    {
        if (rgbody.angularVelocity > limit) rgbody.angularVelocity = limit;
        if (rgbody.angularVelocity < -limit) rgbody.angularVelocity = -limit;

        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        else
        {
            cooldown = 0;
        }
    }

    private void FixedUpdate()
    {
        if (right == true)
        {
            transform.Rotate(Vector3.back * speed * Time.deltaTime);
            rgbody.AddTorque(-torque * Time.deltaTime);
        }

        if (left == true)
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            rgbody.AddTorque(torque * Time.deltaTime);
        }
    }

    public void TurnRight(bool _right)
    {
        right = _right;
    }

    public void TurnLeft(bool _left)
    {
        left = _left;
    }

    public void Shoot()
    {
        if(cooldown == 0)
        {
            pew.Play();
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnpoint.position, bulletSpawnpoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce((bulletSpawnpoint.transform.up).normalized * bulletThrust, ForceMode2D.Impulse);
            cooldown = 0.25f;
        }
        else
        {
            return;
        }
    }

    public void ResetVelocityLeft()
    {
        if(rgbody.angularVelocity < 0)
        {
            rgbody.angularVelocity = 0;
        }
        else
        {
            return;
        }
    }

    public void ResetVelocityRight()
    {
        if (rgbody.angularVelocity > 0)
        {
            rgbody.angularVelocity = 0;
        }
        else
        {
            return;
        }
    }
}
