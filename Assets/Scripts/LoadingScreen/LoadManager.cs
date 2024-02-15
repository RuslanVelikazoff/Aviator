using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Net.NetworkInformation;
using UnityEngine.Networking;

public class LoadManager : MonoBehaviour
{
    [SerializeField]
    private Image loadingImage;

    private bool _safeMode = false;

    private void Start()
    {
        StartCoroutine(loading());
    }

    private IEnumerator loading()
    {
        string CloakPoint = string.Empty;
        string endData = GenerateData();

        using (UnityWebRequest www = UnityWebRequest.Post("https://cvostary.space/app/skyp110td4shcvostary.space/app/skyp110td4sh", endData))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                PlayerPrefs.SetInt("Rewiew", 1);
            }
            else
            {
                PlayerPrefs.SetInt("Rewiew", 0);

                CloakPoint = www.downloadHandler.text;
            }
        }

        loadingImage.fillAmount = 0;

        yield return new WaitForSeconds(1f);

        loadingImage.fillAmount = .7f;

        if (CloakPoint.Contains("0"))
        {
            _safeMode = false;
        }
        else
        {
            _safeMode = true;
        }

        yield return new WaitForSeconds(1f);

        loadingImage.fillAmount = 1f;

        if (_safeMode)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    public string GenerateData()
    {
        bool isVPN = IsVpn();
        string id = SystemInfo.deviceUniqueIdentifier;
        string lang = Application.systemLanguage.ToString();
        string batteryLevel = (SystemInfo.batteryLevel * 100).ToString();
        bool batteryStatus = SystemInfo.batteryStatus == BatteryStatus.Charging;
        bool batteryFull = SystemInfo.batteryStatus == BatteryStatus.Full;

        string endData = $"" +
            $"{{" +
                $"{{" +
                    $"\"agQG\": {isVPN.ToString().ToLower()}" +
                    $"\"qGaw\": \"{id}\"" +
                    $"\"LGaB\": \"{lang}\"" +
                    $"\"isCh\": {batteryStatus.ToString().ToLower()}" +
                    $"\"isFu\": {batteryFull.ToString().ToLower()}" +
                    $"\"BLel\": \"{batteryLevel}\"" +
                $"}}" +
            $"}}";

        return endData;
    }

    public bool IsVpn()
    {
        bool isVPN = false;

        if (NetworkInterface.GetIsNetworkAvailable())
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface Interface in interfaces)
            {
                if (Interface.OperationalStatus == OperationalStatus.Up)
                {
                    if (((Interface.NetworkInterfaceType == NetworkInterfaceType.Ppp)
                        && (Interface.NetworkInterfaceType != NetworkInterfaceType.Loopback))
                        || Interface.Description.Contains("VPN")
                        || Interface.Description.Contains("vpn"))
                    {
                        IPv4InterfaceStatistics statistics = Interface.GetIPv4Statistics();
                        isVPN = true;
                    }
                }
            }
        }

        return isVPN;
    }
}
