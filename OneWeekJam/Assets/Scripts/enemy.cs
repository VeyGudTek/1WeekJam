using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health;
    public Animator animator;
    public float death_timer;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        animator.SetBool("is_dead", false);
        death_timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            animator.SetBool("is_dead", true);
            if (death_timer > 2.5f)
            {
                SceneManager.LoadScene("End");
            }

            //Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (health <= 0)
        {
            death_timer += Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            health -= 1;
        }
    }
}
