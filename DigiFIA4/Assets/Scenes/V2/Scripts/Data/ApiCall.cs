using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class ApiCall : MonoBehaviour
{
    public CatFact catFact;
    public string cFact;
    public int cLength;

    public RandomRiddle randomRiddleClass;
    public string randomRiddle;
    public string randomAnswer;

    public TextMeshProUGUI bookText;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(APICallCat("catfact.ninja/fact"));
        //StartCoroutine(APICallRiddle("https://riddles-api.vercel.app/random"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator APICallCat(string url)
    {

        var www = UnityWebRequest.Get(url);

        yield return www.SendWebRequest();


        catFact = JsonUtility.FromJson<CatFact>(www.downloadHandler.text);
        cFact = catFact.fact;
        cLength = catFact.length;

        Debug.Log(cFact);
        Debug.Log(cLength);


    }

    public IEnumerator APICallRiddle()
    {
        var www = UnityWebRequest.Get("https://riddles-api.vercel.app/random");

        yield return www.SendWebRequest();

        Debug.Log(www.result);


        randomRiddleClass = JsonUtility.FromJson<RandomRiddle>(www.downloadHandler.text);
        randomRiddle = randomRiddleClass.riddle;
        randomAnswer = randomRiddleClass.answer;

        Debug.Log(randomRiddle);
        Debug.Log(randomAnswer);

        bookText.text = randomRiddle;

    }
}

public class CatFact
{
    public string fact;
    public int length;
}

public class RandomRiddle
{
    public string riddle;
    public string answer;
}
