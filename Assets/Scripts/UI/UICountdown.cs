using UnityEngine;
using UnityEngine.UI;

public class UICountdown : MonoBehaviour
{
    [SerializeField, Range(2f,5f)] private float countDownDefaultValue = 3f;
    [SerializeField] private FloatValue startCountdown;
    [SerializeField] private Text countDownText;
    private int prevValue;

    private void OnEnable()
    {
        startCountdown.value = countDownDefaultValue;
        ShowCountdowntime();
    }

    public void OnUpdate()
    {
        startCountdown.value -= Time.deltaTime;
        ShowCountdowntime();

        if (startCountdown.value <= 0f)
            Hide();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    private void ShowCountdowntime()
    {
        int currentCountDownTime = Mathf.RoundToInt(startCountdown.value);
        if (prevValue == currentCountDownTime)
            return;

        countDownText.text = currentCountDownTime.ToString();

        prevValue = currentCountDownTime;
    }
}
