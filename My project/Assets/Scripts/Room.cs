using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    private Player thePlayer;
    private Enemy currentEnemy;
    private GameObject currentRoomTrigger;
    
    public Room(GameObject currentRoomTrigger)
    {
        this.currentRoomTrigger = currentRoomTrigger;
        this.thePlayer = null;
        this.currentEnemy = null;
    }

    public void setPlayer(Player p)
    {
        this.thePlayer = p;

        if(p.getRoom() != null)
        {
        Room playersCurrentRoom = p.getRoom();
        //CORE.destroyRoomGOGivenRoomTrigger(playersCurrentRoom.currentRoomTrigger);
        }

        this.thePlayer.setRoom(this);
    }

    public void setEnemy(Enemy e)
    {
        this.currentEnemy = e;
        
        if(e.getRoom() != null)
        {
            Room enemysCurrentRoom = e.getRoom();
            //CORE.destroyRoomGOGivenRoomTrigger(enemysCurrentRoom.currentRoomTrigger);
        }
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

    public GameObject getRoomTrigger()
    {
        return this.currentRoomTrigger;
    }
}
