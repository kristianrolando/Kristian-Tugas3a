using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    [SerializeField] GameObject[] life;
    int index;
    private void Start()
    {
        index = life.Length;
    }
    public void LifeDecrease()
    {
        index--;
        life[index].SetActive(false);
    }
    private void Update()
    {
        if(index == 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
