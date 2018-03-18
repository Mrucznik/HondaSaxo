using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets._SCRIPTS.Story
{
    class PrisonLabirynthDialog : IDialog
    {
        public void Display()
        {
            SceneManager.LoadScene(3);
        }

        public IDialog GetNextDialog()
        {
            return null;
        }
    }
}
