using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance = null;
    public BoardManager boardScript;
    //テストとしてレベルを3にしておく
    private int level = 3;

    //Awake : Sceneを移動した時即座に実行される
    void Awake () {
        if(instance == null){
            instance = this;
        } else if(instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        
        //BoardManager取得
        boardScript = GetComponent<BoardManager> ();
        InitGame ();
    }

    void InitGame () {
        //BoardManagerのSetupSceneメソッドを実行
        boardScript.SetupScene (level);
    }
}