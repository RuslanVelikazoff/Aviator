using UnityEngine;

public class WebViewTemplate : MonoBehaviour
{
    public int Times;
    public string urlTest;

    private UniWebView webView;
    private SafeArea safeArea;

    private void Awake()
    {
        webView = FindObjectOfType<UniWebView>();
        safeArea = FindObjectOfType<SafeArea>();
    }

    public void DefindAndOpen()
    {
        PlayerPrefs.SetString("End", "True");
        PlayerPrefs.SetString("WasShowed", "1");

        string url = string.Empty;

        if (PlayerPrefs.HasKey("CacheU"))
        {
            url = PlayerPrefs.GetString("CacheU");
        }
        else
        {
            url = urlTest;
            //Add Firebase
        }

        OpenWebView(url);
    }

    private void OpenWebView(string url)
    {
        webView.Frame = new Rect(0, 0, Screen.width, Screen.height);

        webView.Load(url);
        webView.Show();
        //webView.EmbeddedToolbar.Hide();
        UniWebView.SetJavaScriptEnabled(true);

        webView.OnPageFinished += (view, statusCode, url) =>
        {
            if (!PlayerPrefs.HasKey("CacheU"))
            {
                if (Times == 1)
                {
                    if (!url.Contains("widgets-04"))
                        PlayerPrefs.SetString("CacheU", url);
                }
                Times++;
            }
        };

        webView.OnOrientationChanged += (view, orientation) =>
        {
            safeArea.RefreshRectTransform();
            webView.Frame = new Rect(0, 0, Screen.width, Screen.height);
        };

        webView.OnShouldClose += (view) =>
        {
            return false;
        };
    }
}
