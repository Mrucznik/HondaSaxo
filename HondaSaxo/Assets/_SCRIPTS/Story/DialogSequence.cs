using System.Collections.Generic;
using UnityEngine;
namespace Assets._SCRIPTS.Story
{
    public class DialogSequence
    {
        private readonly IDialog _startDialog;
        private IDialog _activeDialog;
        private readonly List<DialogChoice> _choices;

        public DialogSequence(IDialog startDialog)
        {
            _choices = new List<DialogChoice>();
            _startDialog = startDialog;
        }

        public void StartDialog()
        {
            if (_activeDialog != null)
            {
                Debug.Log("Wystartowano podwójnie dialog.");
                return;
            }
            ClearTextPanels();
            _startDialog.Display();
            _activeDialog = _startDialog;

            var elektrij = GameObject.Find("Elektrij");
            if (elektrij != null)
            {
                elektrij.GetComponent<CityMapBehaviour>().paused = true;
            }
            StoryManager.GetInstance().Active = true;
            StoryManager.GetInstance().KeyEnterEvents.Add(OnKeyEnter);
            StoryManager.GetInstance().KeyUpEvents.Add(OnKeyUp);
            StoryManager.GetInstance().KeyDownEvents.Add(OnKeyDown);
        }

        private void StopDialog()
        {
            var elektrij = GameObject.Find("Elektrij");
            if (elektrij != null)
            {
                elektrij.GetComponent<CityMapBehaviour>().paused = false;
            }
            Debug.Log("Test");
            StoryManager.GetInstance().Active = false;
            StoryManager.GetInstance().KeyEnterEvents.Remove(OnKeyEnter);
            StoryManager.GetInstance().KeyUpEvents.Remove(OnKeyUp);
            StoryManager.GetInstance().KeyDownEvents.Remove(OnKeyDown);
        }

        private void ClearTextPanels()
        {
            StoryManager.GetInstance().Text.text = "";
            foreach (var choice in StoryManager.GetInstance().OptionText)
            {
                choice.text = "";
            }
        }

        private void OnKeyEnter()
        {
            if (_activeDialog != null)
            {
                //dodaj do podjętych wyborów
                var dialog = _activeDialog as DialogChoice;
                if (dialog != null)
                {
                    _choices.Add(dialog);
                }

                ClearTextPanels();
                _activeDialog = _activeDialog.GetNextDialog();
                if (_activeDialog != null)
                {
                    _activeDialog.Display();
                }
                else
                {
                    StopDialog();
                }
            }
        }

        private void OnKeyUp()
        {
            var dialog = _activeDialog as DialogChoice;
            if (dialog != null)
            {
                dialog.NextActiveOption();
            }
        }

        private void OnKeyDown()
        {
            var dialog = _activeDialog as DialogChoice;
            if (dialog != null)
            {
                dialog.PreviousActiveOption();
            }
        }
    }
}
