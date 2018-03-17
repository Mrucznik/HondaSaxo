using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class DialogLine : IDialog
    {
        public Character Interlocutor { get; private set; }
        public string Text { get; private set; }
        private GameObject _textObject;

        public DialogLine(Character interlocutor, string text)
        {
            Interlocutor = interlocutor;
            Text = text;
        }

        public void Display(Vector2 position)
        {
            Interlocutor.WyswietlMorde();
            _textObject = new GameObject("text", typeof(RectTransform));
            var newTextComp = _textObject.AddComponent<Text>();
            newTextComp.text = Text;
            newTextComp.font = Font.CreateDynamicFontFromOSFont("Arial", 12);
            newTextComp.color = Color.black;
            newTextComp.fontSize = 16;
            newTextComp.transform.position = position;

            Debug.Log("No jest cos");
        }
    }
}
