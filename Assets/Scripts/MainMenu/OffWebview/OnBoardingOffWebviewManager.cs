using UnityEngine;
using UnityEngine.UI;

public class OnBoardingOffWebviewManager : MonoBehaviour
{
    [SerializeField]
    private GameObject onboardingGameObject1;
    [SerializeField]
    private GameObject onboardingGameObject2;
    [SerializeField]
    private GameObject mainMenuCanvas;
    [SerializeField]
    private GameObject onboardingCanvas;

    [SerializeField]
    private Button nextButton1;
    [SerializeField]
    private Button nextButton2;

    private void Awake()
    {
        mainMenuCanvas.SetActive(false);
        onboardingCanvas.SetActive(true);
    }

    private void Start()
    {
        ButtonClickAction();
    }

    private void ButtonClickAction()
    {
        if (nextButton1 != null)
        {
            nextButton1.onClick.RemoveAllListeners();
            nextButton1.onClick.AddListener(() =>
            {
                onboardingGameObject1.SetActive(false);
                onboardingGameObject2.SetActive(true);
            });
        }

        if (nextButton2 != null)
        {
            nextButton2.onClick.RemoveAllListeners();
            nextButton2.onClick.AddListener(() =>
            {
                onboardingCanvas.SetActive(false);
                mainMenuCanvas.SetActive(true);
            });
        }
    }
}
