using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject panel; // Перетащи сюда панель в инспекторе

    public void Open()
    {
        panel.SetActive(true);
    }

    public void Close()
    {
        panel.SetActive(false);
    }

    public void Toggle()
    {
        panel.SetActive(!panel.activeSelf);
    }
}
