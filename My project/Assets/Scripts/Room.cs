using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    private Player thePlayer;
    private Enemy currentEnemy;
    
    public Room()
    {
        this.thePlayer = null;
        this.currentEnemy = null;
    }

    public void setPlayer(Player p)
    {
        this.thePlayer = p;
        this.thePlayer.setRoom(this);
    }

    public void setEnemy(Enemy e)
    {
        this.currentEnemy = e;
        this.currentEnemy.setRoom(this);
    }

    public Player getPlayer()
    {
        return this.thePlayer;
    }

    public Enemy getEnemy()
    {
        return this.currentEnemy;
    }
}
