using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : BaseObject
{
    private void Start()
    {
        Invoke("SelfDestruct", 10f);
    }

    public void SelfDestruct()
    {
        Destroy(gameObject);
    }

    public override void Click()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
