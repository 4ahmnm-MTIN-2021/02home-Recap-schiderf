using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class colorScript : MonoBehaviour
{
    public Button btn;
    public Image img;
    private Color orangeGelb, kastanienBraun, sonnenuntergang, violettGrau;
    private Color[] colors;
    private System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        void Start()
        {
            orangeGelb = new Color(1.0f, 205 / 255f, 25 / 255f);
            kastanienBraun = new Color(95 / 255f, 34 / 255f, 0.0f);
            sonnenuntergang = new Color(207 / 255f, 63 / 255f, 21 / 255f);
            violettGrau = new Color(102 / 255f, 47 / 255f, 84 / 255f);
            colors = new Color[] { Color.red, orangeGelb, kastanienBraun, sonnenuntergang, violettGrau };
            img.GetComponent<Image>().color = colors[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {

            img.GetComponent<Image>().color = colors[rnd.Next(colors.Length)];
        }
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
