using UnityEngine;
using UnityEngine.UI;

public class TVController : MonoBehaviour
{
    public GameObject screenContent;
    public GameObject[] channels;  
    private int currentChannel = 0;

    public void ToggleTV(bool isOn)
    {
        screenContent.SetActive(isOn);
    }

    public void ChangeChannel(int direction)
    {
        channels[currentChannel].SetActive(false);

        currentChannel += direction;

        if (currentChannel >= channels.Length) currentChannel = 0;
        if (currentChannel < 0) currentChannel = channels.Length - 1;

        channels[currentChannel].SetActive(true);
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}