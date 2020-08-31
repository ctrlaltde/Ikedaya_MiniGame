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

    // Start is called before the first frame update
    void Start()
    {

        EnemySpawn();
        PowerupSpawn();
        BossSpawn();

    }

    // Update is called once per frame
    void Update()
    {
        
       enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0)

        {
            EnemySpawn();
            BossSpawn();
        }


    }

    public void EnemySpawn()
    {

        if (wave < 3)
        {
            Instantiate(enemy, enemyTopSpawn.transform.position, transform.rotation);
            Instantiate(enemy, enemyBottomSpawn.transform.position, transform.rotation);
            wave++;
        }
         

    }

    private void BossSpawn()

    {

        if (wave > 2)
        {
            Instantiate(boss, bossSpawn.transform.position, transform.rotation);
        }
        


    }

    private void PowerupSpawn()

    {

        Vector3 randomSpawn = new Vector3(Random.Range(-10, 9), 1f, Random.Range(-10, 14));

        Instantiate(powerup, randomSpawn, transform.rotation);
        

    }



}
