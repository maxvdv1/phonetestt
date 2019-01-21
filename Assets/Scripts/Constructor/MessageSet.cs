using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MessageSet
{
    public int SetId;
    public List<Message> MessageList = new List<Message>();

    public MessageSet(int id, List<Message> messages)
    {
        this.SetId = id;
        this.MessageList = messages;
    }

    public int GetSetId()
    {
        return this.SetId;
    }

    public List<Message> GetMessageList()
    {
        return this.MessageList;
    }
}