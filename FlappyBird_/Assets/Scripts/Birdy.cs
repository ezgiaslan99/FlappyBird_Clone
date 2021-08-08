using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rigidbody2d;
    public GameManager managerGame;
    public GameObject DeathScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {    //Down 1 tık alır,normali basılı tutma olarak alır
        //0 sol tık,1 sağ tık
        if(Input.GetMouseButtonDown(0))
        {
            //Kuş bu şekilde havada sıçrar
            rigidbody2d.velocity = Vector2.up * velocity;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);        }
    }
}
