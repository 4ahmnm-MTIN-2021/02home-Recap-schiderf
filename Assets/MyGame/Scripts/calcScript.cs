using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class calcScript : MonoBehaviour
{
    public GameObject goInputA, goInputB;
    public GameObject result;

    private InputField fieldA, fieldB;

    // Start is called before the first frame update
    void Start()
    {
        fieldA = goInputA.GetComponent<InputField>();
        fieldB = goInputB.GetComponent<InputField>();
    }

    public void AddNumbers()
    {
        result.GetComponent<TextMeshProUGUI>().text = (int.Parse(fieldA.text) + int.Parse(fieldB.text)).ToString();
    }
}