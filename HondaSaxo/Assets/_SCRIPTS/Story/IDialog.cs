using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public interface IDialog
    {
        void Display();
        IDialog GetNextDialog();
    }
}
