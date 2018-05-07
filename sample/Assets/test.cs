using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //hello Worldを画面に表示
		Debug.Log("Hello,World");
        int age;

        age = 30;
        Debug.Log(age);

        float heiht1 = 160.5f;
        float height2;

        height2 = heiht1;
        Debug.Log(height2);

        string name;
        name = "sannotaku";

        Debug.Log(name);
        int answer;

        answer = 1 + 2;
        Debug.Log(answer);

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        answer = 6 / 4;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;

        answer = n1 + n2;
        Debug.Log(answer);

        answer += 5;
        Debug.Log(answer);

        answer = 10;
        answer++;
        Debug.Log(answer);

        string str1 = "happy";
        string str2 = "birthday";
        string message;


        message = str1 + str2;
        Debug.Log(message);

        str1 += str2;
        Debug.Log(str1);

        string str = "happy";
        int num=123;

        string massage = str + num;
        Debug.Log(message);
        int herbnum = 1;

        if(herbnum==1)
        {
            Debug.Log("HPが50回復");
        }

        int hp = 180;
        if(hp<=50)
        {
            Debug.Log("逃走！！");
        }
        else if(hp>=200)
        {
            Debug.Log("攻撃");
        }
        else
        {
            Debug.Log("防御");
        }

        int x = 1;
        if(x==1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
        //Debug.Log(y);上のスコープ内でyは宣言されているのでここにあるとダメ

        int i;

        for( i=0;i<5;i++)
        {
            Debug.Log(i);
        }

        for(i=0;i<10;i+=2)
        {
            Debug.Log(i);
        }

        for(i=3;i<=5;i++)
        {
            Debug.Log(i);
        }

        for(i=3;i>=0;i--)
        {
            Debug.Log(i);
        }

        int sum = 0;

        for(i=1;i<=10;i++)
        {
            sum += i;
        }
        Debug.Log(sum);



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
