using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;
using UnityEngine.UI;


public class HomeManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Student student;

    public TMP_InputField inp_id;
    public TMP_InputField inp_name;
    public TMP_Dropdown dd_faculty;
    public Toggle tg_agree;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void LoginClick()
    {
        print("Hello Login");
        student.id = inp_id.text;
        student.fullName = inp_name.text;
        student.faculty = dd_faculty.options[dd_faculty.value].text;
        student.agree = tg_agree.isOn;
        //print(student.id);
        //print(student.fullName);
        //print(student.faculty);
        //print(student.agree);

        print(JsonUtility.ToJson(student));
        
    }
}

[System.Serializable]
public class Student
{
    public string id;    
    public string fullName;
    public int age;
    public string faculty;
    public bool agree; 
     
    
    












}

