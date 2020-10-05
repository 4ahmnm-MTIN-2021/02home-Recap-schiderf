using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class calcScript : MonoBehaviour
{
    public InputField varA;
    public InputField varB;
    public Text solution;
    public Button btn;
    public Button nxtbtn;

    public void GetSolution()
    {
        solution.text = AddNumbers().ToString();

    }


    private int AddNumbers()
    {
        int tempResult = int.Parse(varA.text) + int.Parse(varB.text);
        return tempResult;

    }


    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
