using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustServed3 : MonoBehaviour
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

        if (gameflow2.customersServed >= 6)
        {
            customerSlider.value = 1f;
        }
        else
        {
            customerSlider.value = (float)gameflow2.customersServed / 5f;
        }

        UpdateSliderText();
        UpdateSliderValue();
    }

    private void UpdateSliderText()
    {
        customerCountText.text = "Customers Served: " + gameflow2.customersServed.ToString() + "/5";
        
    }

    private void UpdateSliderValue()
    {
        if (gameflow2.customersServed >= 6)
        {
            customerSlider.value = 1f;
        }
        else
        {
   
            customerSlider.value = (float)gameflow2.customersServed / 5f;
        }
    }
}