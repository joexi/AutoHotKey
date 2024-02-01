using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AHKRotation : MonoBehaviour,IAHK
{
    public List<AHKSkill> SkillList = new List<AHKSkill>();
    public List<AHKGrabber> GrabberList = new List<AHKGrabber>();


    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    public virtual void Setup()
    { 
        
    }

    public virtual void AddSkill(AHKSkill skill)
    {
        SkillList.Add(skill);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 30 == 0)
        {
            Grab();
            Excute();
        }
    }

    public void Grab()
    {
        for (int i = 0; i < GrabberList.Count; i++)
        {
            GrabberList[i].Grab();
        }
    }

    public AHKSkill FindSkill()
    {
        for (int i = 0; i < SkillList.Count; i++)
        {
            var skill = SkillList[i];
            if (skill.IsMatchup())
            {
                return skill;
            }
            else {
                Debug.Log("not match ");
            }
        }
        return null;
    }

    public void Excute() {
        var skill = FindSkill();
        if (skill != null)
        {
            skill.Excute();
        }
    }
}
