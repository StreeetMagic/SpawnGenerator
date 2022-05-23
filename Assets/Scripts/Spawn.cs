using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    [SerializeField] private Enemy _enemy;

    private int _number = 0;

    private void Start()
    {
        StartCoroutine(Begin());
    }

    private IEnumerator Begin()
    {
        int count = transform.childCount;
        bool isFinished = false;
        int delay = 2;

        while (isFinished != true)
        {
            if (_number >= count)
                _number = 0;
            
            Instantiate(_enemy);

            _enemy.transform.position = transform.GetChild(_number).transform.position;
            _number++;

            yield return new WaitForSeconds(delay);
        }
    }
}
