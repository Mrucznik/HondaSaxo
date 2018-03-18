using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class AvatarDisplayer : MonoBehaviour
    {
        public Sprite Elektrij;
        public Sprite Aleksiej;
        public Sprite Borys;
        public Sprite Dimitrij;
        public Sprite Elena;
        public Sprite Igor;
        public Sprite Iwan;
        public Sprite Natasza;
        public Sprite Nikolai;
        public Sprite Nina;
        public Sprite Sasza;
        public Sprite Sergiej;
        public Sprite Tamara;
        public Sprite Tatiana;
        public Sprite Wania;

        public void Display(string nazwa)
        {
            switch (nazwa)
            {
                case "Elektrij":
                    this.gameObject.GetComponent<Image>().sprite = Elektrij;
                    break;
                case "Borys":
                    this.gameObject.GetComponent<Image>().sprite = Borys;
                    break;
                case "Dimitrij":
                    this.gameObject.GetComponent<Image>().sprite = Dimitrij;
                    break;
                case "Elena":
                    this.gameObject.GetComponent<Image>().sprite = Elena;
                    break;
                case "Igor":
                    this.gameObject.GetComponent<Image>().sprite = Igor;
                    break;
                case "Ivan":
                    this.gameObject.GetComponent<Image>().sprite = Iwan;
                    break;
                case "Natasza":
                    this.gameObject.GetComponent<Image>().sprite = Natasza;
                    break;
                case "Nikolai":
                    this.gameObject.GetComponent<Image>().sprite = Nikolai;
                    break;
                case "Nina":
                    this.gameObject.GetComponent<Image>().sprite = Nina;
                    break;
                case "Sasza":
                    this.gameObject.GetComponent<Image>().sprite = Sasza;
                    break;
                case "Sergiej":
                    this.gameObject.GetComponent<Image>().sprite = Sergiej;
                    break;
                case "Tamara":
                    this.gameObject.GetComponent<Image>().sprite = Tamara;
                    break;
                case "Tatiana":
                    this.gameObject.GetComponent<Image>().sprite = Tatiana;
                    break;
                case "Wania":
                    this.gameObject.GetComponent<Image>().sprite = Wania;
                    break;
                default:
                    this.GetComponentInChildren<Image>().sprite = Elektrij;
                    break;
            }
        }
    }
}
