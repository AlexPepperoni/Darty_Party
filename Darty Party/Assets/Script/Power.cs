using UnityEngine;
using TMPro;

public class Power : MonoBehaviour
{
    [SerializeField] private Dart1 dart;
    public TMP_Text powerText;

    // Update is called once per frame
    void Update()
    {
        powerText.text = dart.displayedPower.ToString();
    }
}
