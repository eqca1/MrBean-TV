using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TVController : MonoBehaviour
{
    private bool isTvOn = false;

    [Header("Display Objects")]
    public GameObject TV_display; 
    public GameObject channelsParent;

    [Header("Dropdown")]
    public TMP_Dropdown channelDropdown;
    public GameObject channel1;
    public GameObject channel2;

    [Header("Slider")]
    public Slider volumeSlider;

    void Start()
    {
        if (volumeSlider != null)
        {
            AudioListener.volume = volumeSlider.value;
        }

        ApplyTvState(); 
    }

    public void ChangeVolume(float value)
    {
        AudioListener.volume = value;
    }

    public void ChangeChannel(int index)
    {
       
        if (isTvOn)
        {
            if (channel1 != null) channel1.SetActive(index == 0);
            if (channel2 != null) channel2.SetActive(index == 1);
        }
    }

    
    public void ClickPowerButton()
    {
        isTvOn = !isTvOn;
        ApplyTvState();
    }

    private void ApplyTvState()
    {
        if (isTvOn)
        {
            
            if (channelsParent != null) channelsParent.SetActive(true);
            if (TV_display != null) TV_display.SetActive(false); 

            if (channelDropdown != null) ChangeChannel(channelDropdown.value);
        }
        else
        {
          
            if (channelsParent != null) channelsParent.SetActive(false);
            if (TV_display != null) TV_display.SetActive(true); 
        }
    }
}