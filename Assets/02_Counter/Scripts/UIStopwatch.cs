using UnityEngine;
using UnityEngine.UI;

public class UIStopwatch : MonoBehaviour
{
    [SerializeField] private Text _counterText;

    private void Start()
    {
        _counterText.text = 0.ToString();
    }

    private void OnEnable()
    {
        Stopwatch.ChangingText += ChangeText;
    }

    private void OnDisable()
    {
        Stopwatch.ChangingText -= ChangeText;
    }

    public void ChangeText(float counterValue)
    {
        _counterText.text = counterValue.ToString();
    }
}
