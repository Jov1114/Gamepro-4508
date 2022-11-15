using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public TimerSetting script;
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public float a;
    public float b;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(script.waktu == 5 ){
            InvokeRepeating("SpawnEnemy", a, b);
        }
        // if(waktu => 11 && waktu = 15 ){
        //     InvokeRepeating("SpawnEnemy", 2.0f, 1f);
        // }
        
            
        
    }
    void SpawnEnemy()
    {
        int randenemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randenemy], spawnPoints[randSpawnPoint].position, Quaternion.identity );
    }
}
