using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour
{
    public SoundMenu soundmenu;
    public VideoMenu videomenu;
    public MainMenu mainmenu;
    public ControlsMenu controlsmenu;
    private GameObject[] menus;
    // Use this for initialization
    void Start()
    {
        mainmenu = FindObjectOfType<MainMenu>();
        soundmenu = FindObjectOfType<SoundMenu>();
        videomenu = FindObjectOfType<VideoMenu>();
        controlsmenu = FindObjectOfType<ControlsMenu>();
        menus = new GameObject[] { mainmenu.gameObject, videomenu.gameObject, soundmenu.gameObject, controlsmenu.gameObject };
        openMenu(0);
    }
    public void openMenu(int menu)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            if (i == menu)
            {
                menus[i].SetActive(true);
            }
            else
            {
                menus[i].SetActive(false);
            }
        }
    }
}
