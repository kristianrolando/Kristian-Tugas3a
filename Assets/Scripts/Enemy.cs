using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseObject
{
    private void Start()
    {
        Invoke("SelfDestruct", 20f);
    }
    public override void Move()
    {
        //base.Move();
        base.MoveZigZag();
    }

    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
    public override void Click()
    {
        base.Click();
    }

}
