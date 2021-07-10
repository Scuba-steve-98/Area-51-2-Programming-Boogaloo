using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    List<Quest> activeQuests;

    List<Quest> undiscoveredQuest;

    List<Quest> completedQuest;

    Quest currentQuest;

    [SerializeField]
    Quest[] allQuests;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
