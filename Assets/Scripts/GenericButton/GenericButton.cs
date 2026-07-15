using UnityEngine;
using TMPro;


namespace UI
{
    public class GenericButton : MonoBehaviour
    {
        System.Action _action;
        [SerializeField] TMP_Text _buttonName;
        public void SetUp(string buttonName,System.Action action)
        {
            this._action = action;
            this._buttonName.text = buttonName;

        }

        public void OnClick()
        {
            if(_action != null)
            {
                _action();
            }

        }
    }
}
