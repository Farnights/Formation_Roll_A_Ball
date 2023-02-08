using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn_Obstacles : MonoBehaviour
{
    [SerializeField] private GameObject Obstacle;
    [SerializeField] private GameObject[] Spawnposition;
    

    public void SpawnObstacles()

    {
        StartCoroutine(DelaySpawn());
    }

    IEnumerator DelaySpawn()
    {

        yield return new WaitForSeconds(1f);
        Instantiate(Obstacle, Spawnposition[Random.Range(0, Spawnposition.Length)].transform.position, Quaternion.Euler(110f,250f,0f));
    }
}
