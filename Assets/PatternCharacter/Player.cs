using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Player : MonoBehaviour
{
    private Dictionary<Type, IPlayerBehavior> behaviorMap;
    private IPlayerBehavior _playerBehavior;
    private void Start()
    {
        this.InitBehavior();
    }
    private void InitBehavior()
    {
        this.behaviorMap = new Dictionary<Type, IPlayerBehavior>();
        this.behaviorMap[typeof(PlayerBehaviorActive)] = new PlayerBehaviorActive();
        this.behaviorMap[typeof(PlayerBehaviorAgressive)] = new PlayerBehaviorAgressive();
        this.behaviorMap[typeof(PlayerBehaviorIdle)] = new PlayerBehaviorIdle();
    }
    private void SetBehavior(IPlayerBehavior newBehavior)
    {
        if(this._playerBehavior != null)
        {
            this._playerBehavior.Exit();
            this._playerBehavior = newBehavior;
            this._playerBehavior.Enter();
        }
    }
    private void BehaviorDefult()
    {
        this.SetBehaviorIdle();
    }
    private IPlayerBehavior GetBehavior<T>() where T : IPlayerBehavior
    {
        var type = typeof(T);
        return this.behaviorMap[type]; 

    }
    private void Update()
    {
        if (this._playerBehavior != null)
            this._playerBehavior.Update();
    }
    public void SetBehaviorIdle()
    {
        var behavior = this.GetBehavior<PlayerBehaviorIdle>();
        this.SetBehavior(behavior);
    }
    public void SetBehaviorAgressive()
    {
        var behavior = this.GetBehavior<PlayerBehaviorAgressive>();
        this.SetBehavior(behavior);
    }
    public void SetBehaviorActive()
    {
        var behavior = this.GetBehavior<PlayerBehaviorActive>();
        this.SetBehavior(behavior);
    }

}
