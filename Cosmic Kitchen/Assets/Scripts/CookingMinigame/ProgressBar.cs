using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    
    public void SetMaxProgress(float progress)
    {
        slider.maxValue = progress;
        slider.value = 0;

        fill.color = gradient.Evaluate(0);
    }

    public void setProgress(float progress)
    {
        slider.value = progress;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
