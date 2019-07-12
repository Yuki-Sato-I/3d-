using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Set_Status : MonoBehaviour {

    private Animator anim;                      // Animatorへの参照
    private AnimatorStateInfo currentState;     // 現在のステート状態を保存する参照
    private AnimatorStateInfo previousState;    // ひとつ前のステート状態を保存する参照

    public string NAME = null; //キャラクターの名前
    public float HP = 0; //体力
    public float AT = 0; //攻撃力
    public float DF = 0; //防御力
    public Vector3 mypos;　//自分の座標

    void Start()
    {
        anim = GetComponent<Animator>();
        currentState = anim.GetCurrentAnimatorStateInfo(0);
        previousState = currentState;
    }

    public Set_Status()
    {
    }

    public string getName()　//キャラクターの名前を取得
    {
        return NAME;
    }

    public void setName(string NAME)  //キャラクターの名前をセット
    {
        this.NAME = NAME;
    }

    public float getHP()　//キャラクターの体力を取得
    {
        return HP;
    }

    public void setHP(float HP)　//キャラクターの体力をセット
    {
        this.HP = HP;
    }

    public float getAT()　//キャラクターの攻撃力を取得
    {
        return AT;
    }

    public void setAT(float AT)　//キャラクターの攻撃力をセット
    {
        this.AT = AT;
    }

    public float getDF()　//キャラクターの防御力を取得
    {
        return DF;
    }

    public void setDF(float DF)　//キャラクターの防御力をセット
    {
        this.DF = DF;
    }

    public Vector3 getposition() //キャラクターの座標を取得
    {
        return mypos;
    }

    public void setposition(Vector3 mypos)　//キャラクターの座標をセット
    {
        this.mypos = mypos;
    }

    public void Player_Run(bool flag) //キャラクターが走る
    {
        anim.SetBool("Run", flag);
    }

    public void Player_Jab(bool flag) //ジャブ
    {
        anim.SetBool("Jab", flag);
    }

    public void Player_Hikick(bool flag) //ハイキック
    {
        anim.SetBool("Hikick", flag);
    }

    public void Player_Spinkick(bool flag) //スピンキック
    {
        anim.SetBool("Spinkick", flag);
    }

    public void Player_RisingP(bool flag) //ライジングP
    {
        anim.SetBool("Rising_P", flag);
    }

    public void Player_Damagedown(bool flag) //ダメージダウン
    {
        anim.SetBool("Damagedown", flag);
    }
}
