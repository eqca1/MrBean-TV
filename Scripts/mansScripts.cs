using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class mansScripts : MonoBehaviour
{
    private string text;
    private string[] input = {"SVEIKS", "Jauku dienu", "Prieks tevi redzēt", "Uzredzēšanos", "ČAU"};
    private int rand;
    public GameObject inputField;
    public GameObject textField;
    public void GetText()
    {
        rand = Random.Range(0, input.Length);
        text = inputField.GetComponent<TMP_InputField>().text;
        textField.GetComponent<TMP_Text>().text = input[rand] + " " + text + "! "; 
    }
}
