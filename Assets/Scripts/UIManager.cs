using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private UIActions uiActions;

    [SerializeField]
    private GameObject menu;  

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

    private void Awake ()
    {
        uiActions = new UIActions();
        uiActions.Actions.OpenMenu.performed += cxt => OpenCloseMenu();   
    }

    private void OpenCloseMenu()
    {
        menu.SetActive(!menu.activeSelf);
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
