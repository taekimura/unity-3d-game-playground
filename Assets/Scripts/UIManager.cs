using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private UIActions uiActions;

    [SerializeField]
    private GameObject menu;

    public bool MenuOpen { get; set; }

    private static UIManager instance; 

    public static UIManager MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UIManager>();
            }

            return instance;
        }
    }

    public int Score { get; set; }

    private void Awake()
    {
        uiActions = new UIActions();
        uiActions.Actions.OpenMenu.performed += ctx => OpenCloseMenu();
    }

    private void OpenCloseMenu()
    {
        menu.SetActive(!menu.activeSelf);
        MenuOpen = menu.activeSelf;
    }

    public void Continue()
    {
        menu.SetActive(false);
        MenuOpen = false;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnEnable()
    {
        uiActions.Enable();
    }

    private void OnDisable()
    {
        uiActions.Disable();
    }
}
