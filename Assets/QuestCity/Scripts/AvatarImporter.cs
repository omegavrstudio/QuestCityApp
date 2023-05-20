using UnityEngine;
using ReadyPlayerMe.WebView;
using ReadyPlayerMe.AvatarLoader;
using ReadyPlayerMe.Core;
using ReadyPlayerMe.Loader;

public class AvatarImporter : MonoBehaviour
{
    [SerializeField] private WebViewPanel webView;
    private GameObject _importedAvatar;
    private void Start()
    {
        webView.LoadWebView();
    }

    private void LoadAvatar(string obj)
    {
    }
}
