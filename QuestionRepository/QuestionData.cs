using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.QuestionRepository
{
    [CreateAssetMenu(fileName = "Question", menuName = "ScriptableObjects/Question", order = 1)]
    public class QuestionData : ScriptableObject
    {
        public string question;
        public string category;
        [Tooltip("The correct answer should always be listed first, they are ranzomized later")]
        public string[] answers;
    }
}