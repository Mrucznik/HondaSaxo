using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets._SCRIPTS.Story
{
    class DoorDialog : IDialog
    {
        private int sceneID;

        public DoorDialog(int sceneID)
        {
            this.sceneID = sceneID;
        }

        public void Display()
        {
            SceneManager.LoadScene(sceneID);
        }

        public IDialog GetNextDialog()
        {
            return null;
        }
    }
}
