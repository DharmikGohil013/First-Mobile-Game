using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LEVEL2 : MonoBehaviour
{
    public Text displayText;   // Reference to the UI Text component
    private string currentInput = "";  // Stores the current input number as a string
    private int firstOperand = 0;      // Stores the first operand
    private int secondOperand = 0;     // Stores the second operand
    private bool isAddition = false;
    public int x;
    public int result=0;
    public void OnNumberButtonClicked(string number)
    {
            currentInput += number;
            UpdateDisplay(currentInput);
    }
    private void UpdateDisplay(string value)
    {
        displayText.text = value;
    }
    public void plus(string number)
    {
        if (int.TryParse(currentInput, out firstOperand))
        {
            x=1;
            currentInput = "";
            isAddition = true;
            UpdateDisplay("+");
        }

    }
    public void OnEqualsButtonClicked()
    {
        if (int.TryParse(currentInput, out secondOperand) && isAddition)
        {
            if(x==1)
            {
                result = firstOperand + secondOperand;
            }
            else if(x==2)
            {
                 result = firstOperand - secondOperand;
            }
            UpdateDisplay(result.ToString());
            ResetCalculator();
        }
    }
    public void ResetCalculator()
    {
        currentInput = "";
        firstOperand = 0;
        secondOperand = 0;
        isAddition = false;
    }
    public void minus(string number)
    {
        if (int.TryParse(currentInput, out firstOperand))
        {
            x=2;
            currentInput = "";
            isAddition = true;
            UpdateDisplay("-");
        }

    }

}
