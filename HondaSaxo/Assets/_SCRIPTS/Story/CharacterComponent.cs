using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._SCRIPTS.Story
{
    public class CharacterComponent : MonoBehaviour
    {
        public string Name;
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.tag == "Player")
            {
                StoryManager.GetInstance().ActiveQuest.StartCharacterSequence(Name);
            }
        }
    }
}
