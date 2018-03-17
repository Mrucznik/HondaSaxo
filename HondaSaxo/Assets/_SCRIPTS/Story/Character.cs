using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._SCRIPTS.Story
{
    public class Character : MonoBehaviour
    {
        public Character()
        {
            
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Player")
            {

            }
        }

        public void WyswietlMorde()
        {

        }
    }
}
