using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._SCRIPTS.Story
{
    public interface IDialog
    {
        void Display(GameObject canvas, Vector2 position);
    }
}
