using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class SettingManager : MonoBehaviour
{
    public Toggle fullscreenToggle;
    public Dropdown resolutionDropdown;
    public Dropdown TextureQualityDropdown;
    public Dropdown antialiasingDropdown;
    public Dropdown vSyncDropdown;
    public Slider OnMusicVolumeSlider;
    public Button applyButton;

    public AudioSource musicSource;
    public Resolution[] resolutions;
    private GameSettings gameSettings;

    void OnEnable()
    {
        gameSettings = new GameSettings();

        fullscreenToggle.onValueChanged.AddListener(delegate { OnFullscreenToggle(); });
        resolutionDropdown.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        TextureQualityDropdown.onValueChanged.AddListener(delegate { OnTextureQualityChange(); });
        antialiasingDropdown.onValueChanged.AddListener(delegate { OnAntialiasingChange(); });
        vSyncDropdown.onValueChanged.AddListener(delegate { OnVSyncChange(); });
        OnMusicVolumeSlider.onValueChanged.AddListener(delegate { OnMusicVolumeChange(); });
        applyButton.onClick.AddListener(delegate { OnApplyButtonClick(); });

        resolutions = Screen.resolutions;

        foreach (Resolution resolution in resolutions)
        {
            resolutionDropdown.options.Add(new Dropdown.OptionData(resolution.ToString()));
        }

        LoadSettings();
    }
    public void OnFullscreenToggle()
    {
        gameSettings.fullscreen = Screen.fullScreen = fullscreenToggle.isOn;
        Debug.Log("Fullscreen?");
    }

    public void OnResolutionChange()
    {
        Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, Screen.fullScreen);
        gameSettings.resolutionIndex = resolutionDropdown.value;
    }

    public void OnTextureQualityChange()
    {
        QualitySettings.masterTextureLimit = gameSettings.textureQuality = TextureQualityDropdown.value;
    }

    public void OnAntialiasingChange()
    {
        QualitySettings.antiAliasing = (int)Mathf.Pow(2, antialiasingDropdown.value);
        gameSettings.anitialiasing = antialiasingDropdown.value;
    }

    public void OnVSyncChange()
    {
        QualitySettings.vSyncCount = gameSettings.vSync = vSyncDropdown.value;
    }

    public void OnMusicVolumeChange()
    {
        musicSource.volume = gameSettings.musicVolume = OnMusicVolumeSlider.value;
    }

    public void OnApplyButtonClick()
    {
        SaveSettings();
    }

    public void SaveSettings()
    {
        string jsonData = JsonUtility.ToJson(gameSettings, true);
        File.WriteAllText(Application.persistentDataPath + "/gamesettings.json", jsonData);
    }

    public void LoadSettings()
    {
        File.ReadAllText(Application.persistentDataPath + "/gamesettings.json");
        gameSettings = JsonUtility.FromJson<GameSettings>(File.ReadAllText(Application.persistentDataPath + "/gamesettings.json"));


        OnMusicVolumeSlider.value = gameSettings.musicVolume;
        antialiasingDropdown.value = gameSettings.anitialiasing;
        vSyncDropdown.value = gameSettings.vSync;
        TextureQualityDropdown.value = gameSettings.textureQuality;
        resolutionDropdown.value = gameSettings.resolutionIndex;
        fullscreenToggle.isOn = gameSettings.fullscreen;
        Screen.fullScreen = gameSettings.fullscreen;

        resolutionDropdown.RefreshShownValue();

    }

}