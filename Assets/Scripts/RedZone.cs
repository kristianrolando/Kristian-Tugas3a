using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedZone : MonoBehaviour
{
    ScoreManager score;
    LifeManager life;
    private void Start()
    {
        score = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
        life = GameObject.Find("Life Manager").GetComponent<LifeManager>();
    }

    private void Update()
    {
        InputPlayer();
    }

    void InputPlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D click = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            

            if (click.collider != null)
            {
                IClick cl = click.collider.GetComponent<IClick>();
                if(cl != null)
                {
                    cl.Click();
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            life.LifeDecrease();
        }
    }
}
