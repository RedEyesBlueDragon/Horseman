using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Monetization;

public class Adman : MonoBehaviour

{
    public static Adman instance;

    private string store_id = "3266785";

    private string rewarded_video_id = "rewardedVideo";
    private string video_id = "video";


    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            
        }
        else
        {
            instance = this;
            Monetization.Initialize(store_id, false);
        }
    }


    // Start is called before the first frame update
    

    void Update()
    {
        
    }


   

    public void Reward()
    {
        GameControl.instance.Revive();

        
    }
        

 

    public void Display_Inter()
    {
        if (Monetization.IsReady(video_id))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(video_id) as ShowAdPlacementContent;
            Sample.iswat = 1;

            if (ad != null)
            {
                ad.Show();
            }

        }
    }

    public void Display_Reward_Video()
    {
        
        if(Monetization.IsReady(rewarded_video_id))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(rewarded_video_id) as ShowAdPlacementContent;
            Sample.iswat = 1;
            
            if(ad != null)
            {
                ad.Show(Adfinished);
                
            }

        }
                
        
    }

    void Adfinished (ShowResult result)
    {
        if(result == ShowResult.Finished)
        {
            Reward();
        }
        else if(result == ShowResult.Skipped)
        {

        }
        else if(result == ShowResult.Failed)
        {

        }

    }
    

   


}

