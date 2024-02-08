using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    [SerializeField]
    private Image loadingImage;

    private void Start()
    {
        StartCoroutine(loading());
    }

    private IEnumerator loading()
    {
        //TODO: добавить проверку на webview
        loadingImage.fillAmount = 0;

        yield return new WaitForSeconds(1f);

        loadingImage.fillAmount = .7f;

        yield return new WaitForSeconds(1f);

        loadingImage.fillAmount = 1f;

        SceneManager.LoadScene(1);
    }
}
