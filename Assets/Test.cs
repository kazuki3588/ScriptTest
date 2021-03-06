using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
   
    private int hp = 100;
    private int power = 25;
    private int mp;

    public  Boss()
    {
        mp = 53;
    }
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
        Debug.Log("残りhp" + hp);
    }
    //魔法関数
    public void Magic()
    {
        if(mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    
    private void Start()
    {


        
        int[] array = {4,6,7,8,9};
        //配列の要素を順番に表示
        for (int i = 0; i < array.Length; i++ )
        {
            Debug.Log(array[i]);
        }
        //配列の要素を逆順に表示
        for (int i = array.Length - 1; i >= 0 ; i--)
        {
            Debug.Log(array[i]);
        }
        
        Boss lastBoss = new Boss();
        lastBoss.Attack();
        lastBoss.Defence(3);

        Boss midboss = new Boss();
        midboss.Attack();
        midboss.Defence(2);
        //魔法を11回分使う。
        for (int i = 1; i <= 11; i++)
        {
            lastBoss.Magic(); 
        }
    }
    

}
