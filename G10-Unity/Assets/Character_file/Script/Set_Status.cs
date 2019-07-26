using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Set_Status : MonoBehaviour
{

    private Animator anim;                      // Animatorへの参照
    private AnimatorStateInfo currentState;     // 現在のステート状態を保存する参照
    private AnimatorStateInfo previousState;    // ひとつ前のステート状態を保存する参照

    public string NAME = null; //キャラクターの名前
    public float HP = 0; //体力
    public float AT = 0; //攻撃力
    public float DF = 0; //防御力
    public Vector3 mypos; //自分の座標
    public Vector3 myrote; //自分の角度

    void Start()
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
    }

    public Set_Status()
    {
    }

    public string getName() //キャラクターの名前を取得
    {
        return NAME;
    }

    public void setName(string NAME)  //キャラクターの名前をセット
    {
        this.NAME = NAME;
    }

    public float getHP() //キャラクターの体力を取得
    {
        return HP;
    }

    public void setHP(float HP) //キャラクターの体力をセット
    {
        this.HP = HP;
    }

    public float getAT() //キャラクターの攻撃力を取得
    {
        return AT;
    }

    public void setAT(float AT) //キャラクターの攻撃力をセット
    {
        this.AT = AT;
    }

    public float getDF() //キャラクターの防御力を取得
    {
        return DF;
    }

    public void setDF(float DF) //キャラクターの防御力をセット
    {
        this.DF = DF;
    }

    public Vector3 getposition() //キャラクターの座標を取得
    {
        return mypos;
    }

    public void setposition(Vector3 mypos) //キャラクターの座標をセット
    {
        this.mypos = mypos;
    }

    public Vector3 getrotetion()
    {
        return myrote;
    }

    public void setrotetion(Vector3 myrote)
    {
        this.myrote = myrote;
    }

    public void Player_Run() //キャラクターが走る
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        anim.SetBool("Run", true);

    }

    public void Player_Runcancel()
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        anim.SetBool("Run", false);
    }

    public void Player_Jab() //ジャブ
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        anim.SetBool("Jab", true);
    }

    public void Player_Hikick() //ハイキック
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        anim.SetBool("Hikick", true);
    }

    public void Player_Spinkick() //スピンキック
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        anim.SetBool("Spinkick", true);
    }

    public void Player_RisingP() //ライジングP
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        anim.SetBool("Rising_P", true);
    }

    public void Player_Damagedown() //ダメージダウン
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
        anim.SetBool("Damagedown", true);
    }
}