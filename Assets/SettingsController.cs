using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
    using UnityEngine.UI;
public class SettingsController : MonoBehaviour
{
    [Header("Movimiento de Jugadores")]
    [SerializeField] private movement player1;
    [SerializeField] private movementcircle player2;

    [Header("Sliders")]
    [SerializeField] private Slider sliderP1;
    [SerializeField] private TMP_Text textP1;
    [SerializeField] private Slider sliderP2;
    [SerializeField] private TMP_Text textP2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sliderP1.value = player1.speed;
        sliderP2.value = player2.speed;
        textP1.text = player1.speed.ToString("F1");
        textP2.text = player2.speed.ToString("F1");

        sliderP1.onValueChanged.AddListener(OnP1SpeedChanged);
        sliderP2.onValueChanged.AddListener(OnP2SpeedChanged);

    }
    void OnP1SpeedChanged (float value)
    {
        player1.speed = value;
        textP1.text = value.ToString("F1");

    }
    void OnP2SpeedChanged (float value)
    {
        player2.speed = value;
        textP2.text = value.ToString("F1");
    }

}
