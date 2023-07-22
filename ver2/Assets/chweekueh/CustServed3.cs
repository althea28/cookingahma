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
        if (gameflow.sceneCounter == 3)
        {
            customerCountText.text = "Customers Served: " + gameflow2.customersServed.ToString() + "/5";
        }

        else if (gameflow.sceneCounter == 4)
        {
            customerCountText.text = "Customers Served: " + gameflow2.customersServed.ToString() + "/10";
        }
        
        else if (gameflow.sceneCounter == 5)
        {
            customerCountText.text = "Customers Served: " + gameflow2.customersServed.ToString() + "/15";
        }
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