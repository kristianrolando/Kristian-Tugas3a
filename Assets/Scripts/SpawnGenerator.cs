using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] ObjectPrefabs;
    [SerializeField] Transform[] spawnPoint;
    [SerializeField] Text waveText;
    [SerializeField] float timeSpawn = 1f;
    [SerializeField] float timeDelay = 5f;
    [SerializeField] int totalObject;

    int index;
    int currentWave = 1;

    private void Start()
    {
        StartCoroutine(Spawn());
        waveText.text = "Wave : " + currentWave;
    }


    IEnumerator Spawn()
    {
        for (int i = 0; i <= 1000; i++)
        {
            if (index == 0)
            {
                while (index < totalObject)
                {
                    index++;
                    int ranPoint = Random.Range(0, spawnPoint.Length);
                    int ranPref = Random.Range(0, ObjectPrefabs.Length);
                    Instantiate(ObjectPrefabs[ranPref], spawnPoint[ranPoint].position, Quaternion.identity);

                    yield return new WaitForSeconds(timeSpawn);
                }
                currentWave += 1;
                yield return new WaitForSeconds(timeDelay);
            }
            else
            {
                waveText.text = "Wave : " + currentWave;
                index = 0;
                totalObject += 5;
            }
        }
    }
}
