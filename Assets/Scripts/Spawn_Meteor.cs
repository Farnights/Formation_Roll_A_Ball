using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn_Meteor : MonoBehaviour
{
    [SerializeField] private ScenarioDatas _scenrario02;
    
    private void OnEnable()
    {
        Score.MeteorSpawn += SpawnMeteor;
    }
    
    private void OnDisable()
    {
        Score.MeteorSpawn -= SpawnMeteor;
    }

    public void SpawnMeteor()

    {
        StartCoroutine(DelaySpawn());
    }

    IEnumerator DelaySpawn()
    {

        yield return new WaitForSeconds(0.5f);
        Instantiate(_scenrario02.Event, _scenrario02.Eventpos[Random.Range(0, _scenrario02.Eventpos.Length)], Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                Destroy(_scenrario02.Event);
            }
        }
    }
}
