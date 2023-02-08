using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Target : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private GameObject[] _spawnposition;
    
    
    private void OnEnable()
    {
        Player.OnTargetTouched += SpawnTarget;
    }
    
    private void OnDisable()
    {
        Player.OnTargetTouched -= SpawnTarget;
    }


    public void SpawnTarget()

    {
        StartCoroutine(DelaySpawn());
    }

    IEnumerator DelaySpawn()
    {

        yield return new WaitForSeconds(0.5f);
        Instantiate(_target, _spawnposition[Random.Range(0, _spawnposition.Length)].transform.position, Quaternion.identity);
    }
}
