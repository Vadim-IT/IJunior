using System;
using System.Collections;
using UnityEngine;

public class Stopwatch : MonoBehaviour
{
    private float _counterValue;
    private bool _isWork;

    public static event Action<float> ChangingText;

    private void Start()
    {
        _counterValue = 0;
        _isWork = false;
    }

    public void StartStopwatch()
    {
        if (_isWork == false)
        {
            _isWork = true;
            StartCoroutine(CountingTime());
        }
        else
        {
            _isWork = false;
            StopAllCoroutines();
        }
    }

    private IEnumerator CountingTime()
    {
        float waitTime = 0.5f;
        var wait = new WaitForSeconds(waitTime);

        while (true)
        {
            _counterValue ++;
            ChangingText?.Invoke(_counterValue);
            yield return wait;
        }        
    }
}
