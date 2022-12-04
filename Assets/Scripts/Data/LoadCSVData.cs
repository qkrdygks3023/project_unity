using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using System;
using System.IO;


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

        string strFile = "";
        string fullpth = SavePath + "/error";
        StreamWriter sw;
        sw = new StreamWriter(fullpth + ".txt");

        for (var i = 0; i < data.Count; i++)
        {

            try
            {
                string videopath = SavePath + data[i]["url"].ToString();
                FileInfo fileInfo = new FileInfo(videopath);


                if (!fileInfo.Exists)
                {
                    // Debug.Log("파일이 없습니다 video" + videopath);
                    sw.WriteLine(videopath);
                }
            }
            catch (Exception e)
            {
                Debug.Log("e");
                Debug.Log(e);
            }

            try
            {
                string imagepath = SavePath + data[i]["thumbnail"].ToString();
                FileInfo fileInfo01 = new FileInfo(imagepath);


                if (!fileInfo01.Exists)
                {
                    sw.WriteLine(imagepath);
                    // Debug.Log("파일이 없습니다 thumbnail" + imagepath);
                }
            }
            catch (Exception e)
            {
                Debug.Log("e");
                Debug.Log(e);
            }



            // keyword_list.Clear();
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
                List<string> keyword_list = new List<string>();
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
                List<string> keyword_list = new List<string>();
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
                // Debug.Log("keyword - " + keyword);
                // Debug.Log("keyword - " + keyword_list);
                // Debug.Log(" saveData.Data1 - " + saveData.Data1);

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
                List<string> keyword_list = new List<string>();
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
                List<string> keyword_list = new List<string>();
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

        sw.Flush();
        sw.Close();


    }


}


