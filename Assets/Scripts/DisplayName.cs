using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public TMP_Text displayText; // Reference to the Text component where you want to display the input text
    public TMP_InputField usernameInput; // Reference to your input field

    private void Start()
    {
        // Attach an event listener to the input field's "End Edit" event
        usernameInput.onEndEdit.AddListener(DisplayUsername);
    }

    private void DisplayUsername(string inputText)
    {
        // Update the display text with the input field's text
        displayText.text = inputText;
    }
}
