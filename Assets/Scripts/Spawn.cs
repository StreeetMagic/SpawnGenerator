using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    private bool _canSpawn = true;
    private int number = 0;

    private void Update()
    {
        if (_canSpawn)
        {
            int count = transform.childCount;

            if (number >= count)
                number = 0;
            
            enemyPrefab.transform.position = transform.GetChild(number).transform.position;
            Object.Instantiate(enemyPrefab);
            _canSpawn = false;
            StartCoroutine(Pause());
        }
    }

    private IEnumerator Pause()
    {
        yield return new WaitForSeconds(2);
        _canSpawn = true;
        number++;
    }

}
