using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets._SCRIPTS.Story
{
    class HospitalLabirynthDialog : IDialog
    {
        public void Display()
        {
            SceneManager.LoadScene(2);
        }

        public IDialog GetNextDialog()
        {
            return null;
        }
    }
}
