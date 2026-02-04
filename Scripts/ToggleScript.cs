using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject car;
    public GameObject granny;
    public GameObject toggleLeft;
    public GameObject toggleRight;
    public GameObject soundVolume;
    public Sprite[] characterSprites;
    public GameObject sizeSlider;
    public GameObject rotationSlider;

    public void ToggleBean(bool value)
    {
        bean.SetActive(value);
        toggleLeft.GetComponent<Toggle>().interactable = value;
        toggleRight.GetComponent<Toggle>().interactable = value;
    }
/*
    public void ToLeft()
    {
        bean.transform.localScale = new Vector2(1, 1);
    }

    public void ToRight()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
*/
    // Realizēt ToggleFlip metodi, kas apvieno ToLeft un ToRight




    public void ChangeVolume()
    {
        float sizeValue = sizeSlider.GetComponent<Slider>().value;
        soundVolume.transform.localScale = 
                            new Vector2(1f * sizeValue, 1f * sizeValue);
    }
}
