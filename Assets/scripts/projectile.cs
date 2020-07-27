using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField] float bullet_speed;
    [SerializeField] float damage = 50;
    AudioClip shoot_audio;
 
    void Start()
    {
       shoot_audio= GetComponent<AudioClip>();
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * bullet_speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //health reduction
        var h = collision.GetComponent<healthdealer>();
        var e = collision.GetComponent<enemy>();

        if (h && e)
        {
            h.Damagehandler(damage);
            Destroy(gameObject);
        }
    }
}
