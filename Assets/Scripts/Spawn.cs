using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    private bool _canSpawn = true;
    private int _number = 0;

    private void Update()
    {
        if (_canSpawn)
        {
            int count = transform.childCount;

            if (_number >= count)
                _number = 0;
            
            _enemyPrefab.transform.position = transform.GetChild(_number).transform.position;
            Object.Instantiate(_enemyPrefab);
            _canSpawn = false;
            StartCoroutine(Pause());
        }
    }

    private IEnumerator Pause()
    {
        yield return new WaitForSeconds(2);
        _canSpawn = true;
        _number++;
    }

}
