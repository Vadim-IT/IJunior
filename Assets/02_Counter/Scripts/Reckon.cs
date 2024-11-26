using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Reckon : MonoBehaviour
{
    [SerializeField] private Text _counterText;

    private float _counterValue;
    private bool _isWork;

    private void Start()
    {
        _counterValue = 0;
        _counterText.text = _counterValue.ToString();
        _isWork = false;
    }

    public void StartReckon()
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
            _counterValue += waitTime;
            _counterText.text = _counterValue.ToString();
            yield return wait;
        }        
    }
}
