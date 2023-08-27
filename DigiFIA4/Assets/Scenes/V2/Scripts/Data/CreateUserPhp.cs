using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CreateUserPhp : MonoBehaviour
{
       
    public TMP_InputField emailField;
    public TMP_InputField userField;
    public TMP_InputField passwordField;
    public TMP_InputField passwordFieldC;
    public TextMeshProUGUI TextBox;

    public void CreateUserSubmit()
    {
        if (emailField.text != "" & passwordField.text != "" & userField.text != "" & passwordFieldC.text != "")
        {
            if (passwordField.text == passwordFieldC.text)
            {
                StartCoroutine(CreateUser(emailField.text,userField.text, passwordField.text));
            }
            else
            {
                TextBox.text = "Create User Failed:\nPasswords do not match!";
            }

        }

    }

    IEnumerator CreateUser(string email, string username, string password)
    {
        WWWForm form = new WWWForm();
        
        form.AddField("email", email);
        form.AddField("username", username);
        form.AddField("password", password);

        UnityWebRequest www = UnityWebRequest.Post("http://localhost/FIA4/CreateUser.php", form);

        yield return www.SendWebRequest();

        if(www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log(www.error);
        } else
        {
            TextBox.text = "User creation succesful";
        }
    }
}
