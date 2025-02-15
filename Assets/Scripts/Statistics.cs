using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Statistics : MonoBehaviour
{
    [SerializeField] private AgentManager agentManager;
    [SerializeField] private TextMeshProUGUI tmp_Episode, tmp_rewardBiru, tmp_rewardKuning;
    [SerializeField] private TextMeshProUGUI[] tmp_agentName;
    [SerializeField] private TextMeshProUGUI[] tmp_agentMoveX;
    [SerializeField] private TextMeshProUGUI[] tmp_agentMoveZ;
    [SerializeField] private BodyPartAgent[] agents;
    void Update()
    {
        tmp_Episode.SetText("Episode: " + agentManager.currentEpisode);
        tmp_rewardBiru.SetText("Reward Tim Biru: " + agentManager.totalRewardBiru);
        tmp_rewardKuning.SetText("Reward Tim Kuning: " + agentManager.totalRewardKuning);

        for (int i = 0; i < tmp_agentName.Length; i++)
        {
            tmp_agentName[i].SetText("Agent: " + agents[i].name);
            tmp_agentMoveX[i].SetText("moveX: " + agents[i].moveX);
            tmp_agentMoveZ[i].SetText("moveZ: " + agents[i].moveZ);
        }
    }
}
