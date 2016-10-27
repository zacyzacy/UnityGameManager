using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VideoMenu : MonoBehaviour
{
    public Dropdown drpRes, drpAA, drpPreset;
    public Toggle tglFullscreen, tglAFilter, tglShadows;
    public bool fullscreen;
    void Start()
    {
        fullscreen = Screen.fullScreen;
        tglFullscreen.isOn = fullscreen;
        drpRes.onValueChanged.AddListener(delegate
        {
            selectResolution(drpRes);
        });
        drpPreset.onValueChanged.AddListener(delegate
        {
            selectAntiAlias(drpPreset);
        });
        drpAA.onValueChanged.AddListener(delegate
        {
            selectAntiAlias(drpAA);
        });
    }

    // Update is called once per frame
    void Update()
    {
    }

    //change resolution
    private void selectResolution(Dropdown target)
    {
        switch (target.value)
        {
            default:
                break;
            case 0:
                break;
            case 1:
                Screen.SetResolution(1920, 1080, fullscreen);
                break;
            case 2:
                Screen.SetResolution(1280, 720, fullscreen);
                break;
            case 3:
                Screen.SetResolution(720, 480, fullscreen);
                break;
            case 4:
                Screen.SetResolution(720, 576, fullscreen);
                break;
            case 5:
                Screen.SetResolution(800, 600, fullscreen);
                break;
            case 6:
                Screen.SetResolution(1024, 768, fullscreen);
                break;
            case 7:
                Screen.SetResolution(1440, 768, fullscreen);
                break;
            case 8:
                Screen.SetResolution(2560, 1440, fullscreen);
                break;
        }
    }

    public void toggleFullscreen()
    {
        fullscreen = tglFullscreen.isOn;
        Screen.SetResolution(Screen.width, Screen.height, fullscreen);
    }

    //change Preset
    private void selectPreset(Dropdown target)
    {
        if (target.value > 0)
            QualitySettings.SetQualityLevel(target.value - 1);
    }
    //change AA
    private void selectAntiAlias(Dropdown target)
    {
        switch (target.value)
        {
            default:
                break;
            case 0:
                break;
            case 1:
                QualitySettings.antiAliasing = 0;
                break;
            case 2:
                QualitySettings.antiAliasing = 2;
                break;
            case 3:
                QualitySettings.antiAliasing = 4;
                break;
            case 4:
                QualitySettings.antiAliasing = 8;
                break;
        }
    }
    //Anistropic filter on/off
    public void toggleFilter()
    {
        if (tglAFilter.isOn == true)
        {
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Enable;
        }
        else
        {
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
        }
    }
    //shadows on/off
    public void toggleShadows()
    {
        if (tglAFilter.isOn == true)
        {
            QualitySettings.shadowProjection = ShadowProjection.CloseFit;
        }
        else
        {
            QualitySettings.shadowProjection = ShadowProjection.StableFit;
        }
    }

}
