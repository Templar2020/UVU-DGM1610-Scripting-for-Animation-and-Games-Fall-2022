using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 30f;
    public float lifeSpan = 3f;
    private Rigidbody2D rbBullet;

    void Awake()
    {
        rbBullet = GetComponent<Rigidbody2D>();
    }    

    void Update()
    {
        //rbBullet.AddForce(transform.forward * speed, ForceMode2D.Impulse);
      transform.Translate(Vector2.right * speed * Time.deltaTime);
      Destroy(gameObject, lifeSpan);
    }
    
}
