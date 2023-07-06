using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameEndCustServed : MonoBehaviour
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
        if (gameflow.sceneCounter == 1)
        {
            customerCountText.text = "Customers Served: " + gameflow.customersServed.ToString() + "/5";
        }

        else if (gameflow.sceneCounter == 2)
        {
            customerCountText.text = "Customers Served: " + gameflow.customersServed.ToString() + "/10";
        }
        
        else if (gameflow.sceneCounter == 3)
        {
            customerCountText.text = "Customers Served: " + gameflow.customersServed.ToString() + "/15";
        }
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