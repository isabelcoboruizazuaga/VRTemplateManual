using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPadController : MonoBehaviour
{
    public List<int> numberList = new List<int> ();
    public List<Toggle> toggleList = new List<Toggle> ();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void isNumberInList(int number)
    {
        ;
    }
    public void AddNumber(int number, Toggle toggle)
    {
        toggle.interactable = false;
        if (numberList.Contains(number))
        {
            /*numberList.Remove(number);
            toggle.isOn = false;
            toggleList.Remove(toggle);*/
        }
        else
        {
            numberList.Add(number);
            toggleList.Add(toggle);
        }
        if(numberList.Count == 4)
        {
            string sequence= numberList[0]+ ", "+ numberList[1]+ ", "+ numberList[2]+ ", "+ numberList[3];

            Debug.Log(sequence);

            if (sequence != "1, 2, 3, 4"){
                StartCoroutine(Wait());
            }
            else
            {
                StartCoroutine(Wait());
            }
            
            
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("lista toggle: "+toggleList.Count);

        for (var i = 0; i < toggleList.Count; i++)
        {
            toggleList[i].isOn = false;
            toggleList[i].interactable = true;
        }

        /*toggleList[0].isOn = false;
        toggleList[1].isOn = false;
        toggleList[2].isOn = false;
        toggleList[3].isOn = false;
        toggleList.Clear();
        numberList.Clear();

        toggle.interactable = true;*/
        Debug.Log("lista toggle: " + toggleList.Count);
        Debug.Log("________________________________");

    }
    /*
    git add .
    git commit -m "added poke"
    git push

     * */
}
