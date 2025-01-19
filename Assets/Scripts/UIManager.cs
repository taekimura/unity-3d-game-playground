using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private UIActions uiActions;

    [SerializeField]
    private GameObject menu;

    [SerializeField]
    private TMP_Text scoreText;

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

    

    private int score;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            scoreText.text = score.ToString();
        }
    }

    private void Awake()
    {
        uiActions = new UIActions();
        uiActions.Actions.OpenMenu.performed += cxt => OpenCloseMenu();
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
