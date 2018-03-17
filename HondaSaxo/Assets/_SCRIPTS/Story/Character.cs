using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class Character : MonoBehaviour
    {
        public string Name;
        public Sprite Avatar;

        private readonly bool _mojaMorda;

        public Character(bool mojaMorda)
        {
            _mojaMorda = mojaMorda;
        }

        public void WyswietlMorde()
        {
            if (_mojaMorda)
            {
                StoryManager.GetInstance().JegoMordaPanel.SetActive(false);
                StoryManager.GetInstance().MojaMordaPanel.SetActive(true);
            }
            else
            {
                StoryManager.GetInstance().MojaMordaPanel.SetActive(false);
                StoryManager.GetInstance().JegoMordaPanel.SetActive(true);
            }
        }
    }
}
