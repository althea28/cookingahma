using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustServed4 : MonoBehaviour
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

        UpdateSliderText();
        UpdateSliderValue();
    }

    private void UpdateSliderText()
    {
        if (gameflow.sceneCounter == 6)
        {
            customerCountText.text = "Customers Served: " + gameflow3.customersServed.ToString() + "/5";
        }

        else if (gameflow.sceneCounter == 7)
        {
            customerCountText.text = "Customers Served: " + gameflow3.customersServed.ToString() + "/10";
        }
        
        else if (gameflow.sceneCounter == 8)
        {
            customerCountText.text = "Customers Served: " + gameflow3.customersServed.ToString() + "/15";
        }
    }

    private void UpdateSliderValue()
    {
        if (gameflow3.customersServed >= 6)
        {
            customerSlider.value = 1f;
        }
        else
        {
   
            customerSlider.value = (float)gameflow3.customersServed / 5f;
        }
    }
}