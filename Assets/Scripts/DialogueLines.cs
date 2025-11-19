using UnityEngine;
using TMPro;

public class DialogueLines : MonoBehaviour
{
    [SerializeField] string[] timelineTextLines;
    [SerializeField] TMP_Text dialogueText;
   
   int currentLineIndex = 0;
   
   public void NextDialogueLine()
    {
        currentLineIndex++;
        if (currentLineIndex < timelineTextLines.Length)
        {
            dialogueText.text = timelineTextLines[currentLineIndex];
        }
    }
}
