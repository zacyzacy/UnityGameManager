using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundMenu : MonoBehaviour
{
    public Slider music, game;
    // Use this for initialization
    void Start()
    {
        music.onValueChanged.AddListener(delegate
        {
            musicVolume(music);
        });
        game.onValueChanged.AddListener(delegate
        {
            gameVolume(game);
        });
    }
    private void musicVolume(Slider target)
    {
        GameManager.instance.musicVolume = target.value;
    }
    private void gameVolume(Slider target)
    {
        GameManager.instance.musicVolume = target.value;
    }
}
