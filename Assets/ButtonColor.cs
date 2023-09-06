using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{

    private Button[] buttons;
    private Color originalColor;
    private Button selectedButton;

    private void Start()
    {
        buttons = FindObjectsOfType<Button>();
        originalColor = buttons[0].colors.normalColor;

        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => ChangeButtonColor(button));
        }
    }

    private void ChangeButtonColor(Button button)
    {
        // Revert the color of the previously selected button
        if (selectedButton != null)
        {
            selectedButton.colors = ColorBlock.defaultColorBlock;
        }

        // Change the color of the clicked button to green
        ColorBlock colors = button.colors;
        colors.normalColor = Color.green;
        button.colors = colors;

        selectedButton = button;
    }
}
