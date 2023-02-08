using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Bomb : MonoBehaviour
{
    
    [SerializeField] private ScenarioDatas _scenrario01;
    
    private void OnEnable()
    {
        Score.BombSpawn += SpawnBomb;
    }
    
    private void OnDisable()
    {
        Score.BombSpawn -= SpawnBomb;
    }

    public void SpawnBomb()

    {
        StartCoroutine(DelaySpawn());
    }

    IEnumerator DelaySpawn()
    {

        yield return new WaitForSeconds(2.5f);
        Instantiate(_scenrario01.Event, _scenrario01.Eventpos[Random.Range(0, _scenrario01.Eventpos.Length)], Quaternion.identity);
    }
}
