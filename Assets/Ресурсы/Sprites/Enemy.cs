using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0.1f;
    public Animator animator;
    public int helth;
    public int helthMax;
    public float AddLevel = 0.2f;
    public int addLevelH = 2;
    // Start is called before the first frame update
    void Start()
    {
        helthMax += addLevelH * LevelControler.level;
        speed += AddLevel * LevelControler.level;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float enemePosX = transform.position.x;
        float playerPosX = Player.sing.transform.position.x;

        if(enemePosX > playerPosX)
        {
            transform.position += (-1) * transform.right * speed * Time.deltaTime;
            animator.SetBool("isAnim", true);
        }
        else
        {
            animator.SetBool("isAnim", false);
        }

    }
    public void TakeDamage()
    {
        helth--;
        if(helth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

