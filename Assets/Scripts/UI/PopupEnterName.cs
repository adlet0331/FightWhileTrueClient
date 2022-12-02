﻿using System.Threading.Tasks;
using NonDestroyObject;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PopupEnterName : Popup
    {
        [SerializeField] private TMP_InputField nameInputField;
        [SerializeField] private TMP_Text warning_text;

        public void OKButton()
        {
            var userName = nameInputField.text;
            if (userName.Length == 0 || userName.Length > 20)
            {
                warning_text.text = "Please Check Nickname's length";
                return;
            }

            warning_text.text = "Internet Conecting...";

            var task = Task.Run(() =>NetworkManager.Instance.CreateNewUser(userName));
            task.Wait();
            if (task.Result == CreateNewUserResult.Success)
            {
                SLManager.Instance.InitUser(NetworkManager.Instance.playerId, userName);
                Close();
            }
            else
            {
                Debug.LogAssertion(task.Result.ToString());
            }
        }
    }
}