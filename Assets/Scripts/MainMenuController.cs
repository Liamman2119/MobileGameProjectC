using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    private UIDocument _document;
    private VisualElement _mainMenuVisualTree;
    private VisualElement _startButton;
    private VisualElement _quitButton;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _mainMenuVisualTree = _document.rootVisualElement.Q("MainMenuVisualTree");
        _startButton = _mainMenuVisualTree.Q("StartButton") as Button;
        _quitButton = _mainMenuVisualTree.Q("QuitButton") as Button;
    }

    private void OnEnable()
    {
        _startButton.RegisterCallback<ClickEvent>(OnStartButtonClick);
        _quitButton.RegisterCallback<ClickEvent>(OnQuitButtonClick);
    }
    private void OnDisable()
    {
        _startButton.UnregisterCallback<ClickEvent>(OnStartButtonClick);
        _quitButton.UnregisterCallback<ClickEvent>(OnQuitButtonClick);
    }

    private void OnStartButtonClick(ClickEvent evt)
    {
        SceneManager.LoadScene("GameplayScene");
    }

    private void OnQuitButtonClick(ClickEvent evt)
    {
        Application.Quit();
    }
}
