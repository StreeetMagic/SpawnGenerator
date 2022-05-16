using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private void Start()
    {
        enemyPrefab.transform.position = transform.position;
        Object.Instantiate(enemyPrefab);
    }

}
