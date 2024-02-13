using UnityEngine;
using UnityEngine.UI;

public class OnBoardingOnWebviewManager : MonoBehaviour
{
    [SerializeField]
    private GameObject onboardingGameObject1;
    [SerializeField]
    private GameObject onboardingGameObject2;
    [SerializeField]
    private GameObject webviewGameObject;

    [SerializeField]
    private Button nextButton1;
    [SerializeField]
    private Button nextButton2;
    [SerializeField]
    private Button notificationButton;
    [SerializeField]
    private Button webviewButton;

    private WebViewTemplate webView;

    private void Awake()
    {
        onboardingGameObject1.SetActive(true);
        onboardingGameObject2.SetActive(false);
        webviewGameObject.SetActive(false);
    }

    private void Start()
    {
        webView = FindObjectOfType<WebViewTemplate>();
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
                onboardingGameObject2.SetActive(false);
                webviewGameObject.SetActive(true);
            });
        }

        //TODO: доработать функционал
        if (notificationButton != null)
        {
            notificationButton.onClick.RemoveAllListeners();
            notificationButton.onClick.AddListener(() =>
            {
                Debug.Log("Notification button");
            });
        }

        if (webviewButton != null)
        {
            webviewButton.onClick.RemoveAllListeners();
            webviewButton.onClick.AddListener(() =>
            {
                webView.DefindAndOpen();
            });
        }
    }

}
