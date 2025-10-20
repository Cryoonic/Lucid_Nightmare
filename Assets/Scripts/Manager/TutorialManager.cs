using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject tutorialPanel;   // Panel tutorial
    public Button startButton;         // Tombol Start Game

    private CanvasGroup canvasGroup;   // Untuk fade atau disable raycast

    void Awake()
    {
        if (tutorialPanel == null)
        {
            Debug.LogError("TutorialPanel belum diassign di Inspector!");
            return;
        }

        // Pastikan panel aktif saat awal
        tutorialPanel.SetActive(true);

        // Ambil CanvasGroup
        canvasGroup = tutorialPanel.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = tutorialPanel.AddComponent<CanvasGroup>();
        }

        // Setup tombol
        if (startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
            Debug.Log("StartButton listener added");
        }
        else
        {
            Debug.LogError("StartButton belum diassign di Inspector!");
        }

        // Freeze game sementara
        Time.timeScale = 0f;
    }

    void StartGame()
    {
        Debug.Log("Start button clicked!");

        // Nonaktifkan panel
        if (canvasGroup != null)
        {
            canvasGroup.alpha = 0f;          // hilangkan visual
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }

        tutorialPanel.SetActive(false);      // optional, sudah di-handle CanvasGroup
        Time.timeScale = 1f;                 // mulai game
    }
}
