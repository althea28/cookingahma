using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustServed2 : MonoBehaviour
{
    public Slider customerSlider;
    public TextMeshProUGUI customerCountText;

    private void Start()
    {
        UpdateSliderValue();
        UpdateSliderText();
    }

    public void Update()
    {

        if (gameflow.customersServed >= 6)
        {
            customerSlider.value = 1f;
        }
        else
        {
            customerSlider.value = (float)gameflow.customersServed / 5f;
        }

        UpdateSliderText();
        UpdateSliderValue();
    }

    private void UpdateSliderText()
    {
        customerCountText.text = "Customers Served: " + gameflow.customersServed.ToString() + "/5";
        
    }

    private void UpdateSliderValue()
    {
        if (gameflow.customersServed >= 6)
        {
            customerSlider.value = 1f;
        }
        else
        {
   
            customerSlider.value = (float)gameflow.customersServed / 5f;
        }
    }
}