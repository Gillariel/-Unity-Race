using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject panel;
    public GameObject menu, menuDisable;

    public void Quit()
    {
        panel.SetActive(false);
        Application.Quit();
    }

    public void Cancel()
    {
        ToggleMenu();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void TryToQuit()
    {
        ToggleMenu();
    }

#region utils function
    private void ToggleMenu()
    {
        bool _menu, _menuDisable, _panel;
        _menu = (menu.activeSelf) ? false : true;
        _menuDisable = (menuDisable.activeSelf) ? false : true;
        _panel = (panel.activeSelf) ? false : true;
        menu.SetActive(_menu); menuDisable.SetActive(_menuDisable); panel.SetActive(_panel);
    }
    private void ObscureImage(RawImage c)
    {
        Color newC = c.color;
        newC.a = 0.25f;
        c.color = newC;
    }

    private void ResetColor(RawImage c)
    {
        Color newC = c.color;
        newC.a = 1;
        c.color = newC;
    }
#endregion
}
