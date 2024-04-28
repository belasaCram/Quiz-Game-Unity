using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.QuestionRepository
{
    public class AnswerButton : MonoBehaviour
    {
        private bool isCorrect;
        [SerializeField] private Text answerText;

        // To make it ask a new question after the first question
        [SerializeField] private QuestionSetup questionSetup;

        public void SetAnswerText(string newText)
        {
            answerText.text = newText;
        }

        public void SetIsCorrect(bool newBool)
        {
            isCorrect = newBool;
        }

        public void OnClick()
        {
            if (isCorrect)
            {
                Debug.Log("CORRECT ANSWER");
            }
            else
            {
                Debug.Log("WRONG ANSWER");
            }

            // Get the next question if there are more in the list
            if (questionSetup.questions.Count > 0)
            {
                // Generate a new question
                questionSetup.Start();
            }
        }
    }
}