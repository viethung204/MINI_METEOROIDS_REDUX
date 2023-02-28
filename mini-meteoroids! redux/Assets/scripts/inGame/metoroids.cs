using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metoroids : MonoBehaviour
{
    Rigidbody2D rigid;
    public float Speed;

    Scored scored;
    public int score;

    Animator animator;
    Animator shipAnimator;

    bool go = true;

    Audio explosion;

    public whenDead death;

    metoroids[] MET;

    BoxCollider2D selfCollider;

    // Start is called before the first frame update
    void Start()
    {
        selfCollider = gameObject.GetComponent<BoxCollider2D>();
        rigid = gameObject.GetComponent<Rigidbody2D>();
        rigid.angularVelocity = Random.Range(-150f, 150f);
        scored = GameObject.Find("ScoreManager").GetComponent<Scored>();
        animator = gameObject.GetComponent<Animator>();
        explosion = GameObject.Find("audio").GetComponent<Audio>();
        shipAnimator = GameObject.Find("spaceship").GetComponent<Animator>();

        death = GameObject.Find("death").GetComponent<whenDead>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //rigid.AddForce((targetSpawn.transform.position - transform.position) * Speed * Time.deltaTime, ForceMode2D.Impulse);
        if (go)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, Speed * Time.deltaTime);
        }
        
        Object.Destroy(gameObject, 10f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            selfCollider.enabled = false;
            explosion.ExplosionAudio();
            rigid.angularVelocity = 0;
            //rigid.velocity = Vector3.zero;
            go = false;
            scored.METDestroyed(score);
            animator.SetTrigger("hit");
            collision.gameObject.SetActive(false);
            Object.Destroy(gameObject, 0.4f);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            explosion.ExplosionAudio();
            rigid.angularVelocity = 0;
            go = false;
            shipAnimator.SetTrigger("hit");
            //Object.Destroy(collision.gameObject, 0.349f);
            Object.Destroy(gameObject);
            death.dead();
        }
    }
}
