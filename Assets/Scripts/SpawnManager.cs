using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    public GameObject enemyTopSpawn;
    public GameObject bossSpawn;
    public GameObject enemyBottomSpawn;
    public GameObject powerup;
    public GameObject boss;

    public int wave = 0;
    public int enemyCount;
    public bool bossSpawnCond = false;

    // Start is called before the first frame update
    void Start()
    {

        EnemySpawn();
        
        
    }

    // Update is called once per frame
    void Update()
    {

        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0 & wave == 0)
        {
            BossSpawn();
            PowerupSpawn();

        }
        
        

    }

    public void EnemySpawn()
    {

            Instantiate(enemy, enemyTopSpawn.transform.position, transform.rotation);
            Instantiate(enemy, enemyBottomSpawn.transform.position, transform.rotation);
    }

    public void BossSpawn()

    {    
            Instantiate(boss, bossSpawn.transform.position, transform.rotation);
            wave++;
    }

    private void PowerupSpawn()

    {

        Vector3 randomSpawn = new Vector3(Random.Range(-8, 2), 1f, Random.Range(-1, 18));

            Instantiate(powerup, randomSpawn, transform.rotation);

    }



}
