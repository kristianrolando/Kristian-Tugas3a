using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour, IClick
{
    float speed = 6;

    public virtual void Move()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    private void Update()
    {
        Move();
    }
    bool changeDirection;
    public virtual void MoveZigZag()
    {
        if(changeDirection)
        {
            MoveRight();
        }else
        {
            MoveLeft();
        }
        if (transform.position.x <= -2.23f)
        {
            changeDirection = true;
        }
        else if (transform.position.x >= 2.23f)
        {
            changeDirection = false;
        }
    }

    void MoveRight()
    {
        transform.Translate(new Vector2(0.5f, -0.5f) * Time.deltaTime * speed);
    }
    void MoveLeft()
    {
        transform.Translate(new Vector2(-0.5f, -0.5f) * Time.deltaTime * speed);
    }

    public virtual void Click()
    {
        ScoreManager.instantiate.ScoreIncrement();
        Destroy();
    }

    public virtual void Destroy()
    {
        Destroy(this.gameObject);
    }
}
