using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> fish;

    private readonly float _spawnrate = 2.0f;
    private readonly float _spawnrange = 5.0f;

    private void Start()
    {
        StartCoroutine(SpawnFish());
    }

    private Vector3 GenerateRandomSpawnPosition()
    {
        var spawnPosX = Random.Range(-_spawnrange, _spawnrange);
        var spawnPosZ = Random.Range(-_spawnrange, _spawnrange);
        var randomPos = new Vector3(spawnPosX, 0.5f, spawnPosZ);
        return randomPos;
    }

    IEnumerator SpawnFish()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnrate);
            int index = Random.Range(0, fish.Count);
            Instantiate(fish[index], GenerateRandomSpawnPosition(), Quaternion.identity);
        }
    }

}