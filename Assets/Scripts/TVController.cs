using UnityEngine;
using UnityEngine.UI;

public class TVController : MonoBehaviour
{
    public GameObject screenContent;
    public GameObject[] channels;
    private int currentChannelIndex = 0;

    public void ToggleTV(bool isOn)
    {
        screenContent.SetActive(isOn);
    }

    public void ChangeChannel(int direction)
    {
        channels[currentChannelIndex].SetActive(false);

        currentChannelIndex += direction;

        if (currentChannelIndex >= channels.Length) currentChannelIndex = 0;
        if (currentChannelIndex < 0) currentChannelIndex = channels.Length - 1;

        channels[currentChannelIndex].SetActive(true);
    }
public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}
