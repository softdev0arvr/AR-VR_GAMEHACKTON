using UnityEngine;
using System.Collections;

public class Singleton
{
    private static Singleton _instance = null;

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }

    void Destory()
    {
        _instance = null;
    }

    public bool Trigger = false;
    public bool Stage1Key = false;
    public bool EmptyEvent = false;

    public bool PasswordModeCtrl = false;
    public int PasswordMode = 0;
    public int PasswordCount = 0;
    public string Password = null;
    

}
