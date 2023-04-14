using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuAction : MonoBehaviour
{
   

   public GameObject panel, leave, cam;
   public GameObject avatar;
   public InputField txtInput;

   private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        leave.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    
    public void PindahScene(string nama)
    {
        SceneManager.LoadScene(nama);
    }

    public void JoinRoom()
    {
        panel.SetActive(false);
        leave.SetActive(true);
        cam.SetActive(false);   

        GameObject avatarName = GameObject.Find("LblName");
        avatarName.GetComponent<TextMeshPro>().text = txtInput.text;
    }

    public void ShowPanel()
    {
        Destroy(player);
        
        panel.SetActive(true);
        leave.SetActive(false);
        cam.SetActive(true);
    }
}
