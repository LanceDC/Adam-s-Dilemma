using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{
    private PlayerController player;
    public GameObject playerPauseBackground;
    public GameObject dot;


    private PlayerControls controls;

    //public delegate void Pause();
    ////public static event Pause PausePlayer;
    //public static event Pause PauseGame;

    public static GameManager instance;

    public Text gameOverText;
    public Animator gameOverAnimator;

    private bool paused = false;

    [SerializeField] private GameObject pauseMenuObject;
    [SerializeField] private GameObject spareCam;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.General.Pause.performed += ctx => PauseGame();
    }

    private void OnEnable()
    {
        instance = this;
        controls.General.Enable();
    }

    private void OnDisable()
    {
        controls.General.Disable();
    }


    void Start()
    {
        player = PlayerController.instance;
    }


    private void StopPlayer()
    {
        player.gameObject.SetActive(!player.gameObject.activeSelf);
        spareCam.SetActive(!spareCam.activeSelf);
    }

    private void ChangePlayerController()
    {
        player.enabled = !player.enabled;
        dot.SetActive(!dot.activeSelf);

    }

    public static void PausePlayer()
    {
        instance.ChangePlayerController();
    }

    public void GameOver(LastChoiceUsed choice)
    {
        switch (choice)
        {
            case LastChoiceUsed.Burn:
                StartCoroutine(ScreenTransition("Burn The Evidence"));
                break;
            case LastChoiceUsed.Photo:
                StartCoroutine(ScreenTransition("Take Photos Of the Evidence"));
                break;
            case LastChoiceUsed.Leave:
                StartCoroutine(ScreenTransition("Leave"));
                break;
            default:
                Debug.LogWarning("Did not do anything");
                break;
        }
    }

    private IEnumerator ScreenTransition(string choice)
    {
        gameOverText.text = "You Chose To " + choice;
        while(true)
        {
            gameOverAnimator.SetTrigger("GameEnded");

            yield return new WaitForSeconds(4f);

            SceneManager.LoadScene("Scenes/StartScreen");
        }
    }

    public void PauseGame()
    {
        StopPlayer();
        Time.timeScale = Time.timeScale == 0 ? 1f : 0f;
        ChangePlayerController();
        pauseMenuObject.SetActive(!pauseMenuObject.activeSelf);
    }
}
