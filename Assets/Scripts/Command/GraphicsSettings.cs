using UnityEngine;

public class GraphicsSettings : MonoBehaviour
{
    public void SetBrightness(float value)
    {
        RenderSettings.ambientIntensity = value;
        PlayerPrefs.SetFloat("Brightness", value);
    }

    void Start()
    {
        float saved = PlayerPrefs.GetFloat("Brightness", 1f);
        RenderSettings.ambientIntensity = saved;
    }
}
