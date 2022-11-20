using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using System;


public class LoadCSVData : MonoBehaviour
{
    // Start is called before the first frame update
    string SavePath = Application.streamingAssetsPath;
    public List<Dictionary<string, string>> key01 = new List<Dictionary<string, string>>();




    void Start()
    {
        LoadCSV();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadCSV()
    {
        List<Dictionary<string, object>> data = CSVReader.Read("data.csv");
        SaveData saveData = new SaveData();
        List<string> keyword_list = new List<string>();

        for (var i = 0; i < data.Count; i++)
        {
            keyword_list.Clear();
            if (data[i]["type"].ToString() == "기록영상")
            {
                // Debug.Log("index " + (i).ToString() + " : " + data[i]["type"]);
                var type = data[i]["type"].ToString();
                var group_year_str = data[i]["group_year"].ToString();
                var group_year = 0;
                if (Int32.TryParse(group_year_str, out int result))
                {
                    group_year = result;
                }
                else
                {
                    group_year = 0;
                }
                var title = data[i]["title"].ToString();
                var place = data[i]["place"].ToString();
                var year = data[i]["year"].ToString();
                var keyword = data[i]["keyword"].ToString();
                keyword_list.Add(keyword);

                var playtime_str = data[i]["playtime"].ToString();
                var playtime = 0;
                if (Int32.TryParse(playtime_str, out int result01))
                {
                    playtime = result01;
                }
                else
                {
                    playtime = 0;
                }
                var summary = data[i]["summary"].ToString();
                var url = data[i]["url"].ToString();
                var thumbnail = data[i]["thumbnail"].ToString();


                saveData.Data0.Add(new Datajson(
                     type,
                     group_year,
                     title,
                     place,
                     year,
                     keyword_list,
                     playtime,
                     summary,
                     url,
                     thumbnail
                     ));

            }
            else if (data[i]["type"].ToString() == "전쟁영화")
            {
                // Debug.Log("index " + (i).ToString() + " : " + data[i]["type"]);
                var type = data[i]["type"].ToString();
                var group_year_str = data[i]["group_year"].ToString();
                var group_year = 0;
                if (Int32.TryParse(group_year_str, out int result))
                {
                    group_year = result;
                }
                else
                {
                    group_year = 0;
                }
                var title = data[i]["title"].ToString();
                var place = data[i]["place"].ToString();
                var year = data[i]["year"].ToString();
                var keyword = data[i]["keyword"].ToString();
                keyword_list.Add(keyword);

                var playtime_str = data[i]["playtime"].ToString();
                var playtime = 0;
                if (Int32.TryParse(playtime_str, out int result01))
                {
                    playtime = result01;
                }
                else
                {
                    playtime = 0;
                }
                var summary = data[i]["summary"].ToString();
                var url = data[i]["url"].ToString();
                var thumbnail = data[i]["thumbnail"].ToString();


                saveData.Data1.Add(new Datajson(
                     type,
                     group_year,
                     title,
                     place,
                     year,
                     keyword_list,
                     playtime,
                     summary,
                     url,
                     thumbnail
                     ));

            }
            else if (data[i]["type"].ToString() == "다큐멘터리")
            {
                // Debug.Log("index " + (i).ToString() + " : " + data[i]["type"]);
                var type = data[i]["type"].ToString();
                var group_year_str = data[i]["group_year"].ToString();
                var group_year = 0;
                if (Int32.TryParse(group_year_str, out int result))
                {
                    group_year = result;
                }
                else
                {
                    group_year = 0;
                }
                var title = data[i]["title"].ToString();
                var place = data[i]["place"].ToString();
                var year = data[i]["year"].ToString();
                var keyword = data[i]["keyword"].ToString();
                keyword_list.Add(keyword);

                var playtime_str = data[i]["playtime"].ToString();
                var playtime = 0;
                if (Int32.TryParse(playtime_str, out int result01))
                {
                    playtime = result01;
                }
                else
                {
                    playtime = 0;
                }
                var summary = data[i]["summary"].ToString();
                var url = data[i]["url"].ToString();
                var thumbnail = data[i]["thumbnail"].ToString();


                saveData.Data2.Add(new Datajson(
                     type,
                     group_year,
                     title,
                     place,
                     year,
                     keyword_list,
                     playtime,
                     summary,
                     url,
                     thumbnail
                     ));

            }
            else if (data[i]["type"].ToString() == "구술영상")
            {
                // Debug.Log("index " + (i).ToString() + " : " + data[i]["type"]);
                var type = data[i]["type"].ToString();
                var group_year_str = data[i]["group_year"].ToString();
                var group_year = 0;
                if (Int32.TryParse(group_year_str, out int result))
                {
                    group_year = result;
                }
                else
                {
                    group_year = 0;
                }
                var title = data[i]["title"].ToString();
                var place = data[i]["place"].ToString();
                var year = data[i]["year"].ToString();
                var keyword = data[i]["keyword"].ToString();
                keyword_list.Add(keyword);

                var playtime_str = data[i]["playtime"].ToString();
                var playtime = 0;
                if (Int32.TryParse(playtime_str, out int result01))
                {
                    playtime = result01;
                }
                else
                {
                    playtime = 0;
                }
                var summary = data[i]["summary"].ToString();
                var url = data[i]["url"].ToString();
                var thumbnail = data[i]["thumbnail"].ToString();


                saveData.Data3.Add(new Datajson(
                     type,
                     group_year,
                     title,
                     place,
                     year,
                     keyword_list,
                     playtime,
                     summary,
                     url,
                     thumbnail
                     ));

            }
            else if (data[i]["type"].ToString() == "url")
            {
                saveData.url = data[i]["group_year"].ToString();
            }

        }


        string json = JsonUtility.ToJson(saveData, true);
        string saveFilePath = SavePath + "/datalist2.json";

        File.WriteAllText(saveFilePath, json);
    }


}


