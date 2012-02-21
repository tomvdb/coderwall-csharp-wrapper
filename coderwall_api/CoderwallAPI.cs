// -----------------------------------------------------------------------
// <copyright file="CoderwallAPI.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace coderwall_api
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Runtime.Serialization;
  using System.Web.Script.Serialization;
  using System.Net;
  using System.IO;
  
  /// <summary>
  /// TODO: Update summary.
  /// </summary>
  public class CoderwallAPI
  {
    public struct BadgesStruct
    {
      public string Name;
      public string Description;
      public string BadgeImage;
    };

    public string Username;
    public string Name;
    public string Location;
    public int Endorsements;
    public int BadgeCount;
    public BadgesStruct[] Badges;

    public CoderwallAPI(string UserName)
    {
      string apiCall = "http://coderwall.com/" + UserName + ".json";

      doWebRequest(apiCall);
    }

    private void doWebRequest(string apicall)
    {
      string url = apicall;

      HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apicall);
      request.Method = "GET";
      request.ContentType = "application/json; charset=utf-8";

      HttpWebResponse response;

      try
      {
        response = (HttpWebResponse)request.GetResponse();
      }
      catch (Exception Ex)
      {
        // TODO: correct error handling
        return;
      }

      TextReader temp = new StreamReader(response.GetResponseStream());
      string data = temp.ReadToEnd();

      temp.Close();

      var serializer = new JavaScriptSerializer();
      serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

      dynamic obj = serializer.Deserialize(data, typeof(object));

      Username = obj.username;
      Name = obj.name;
      Location = obj.location;
      Endorsements= (int)obj.endorsements;
      BadgeCount = (int)obj.badges.Count;

      Badges = new BadgesStruct[BadgeCount];

      for (int c = 0; c < BadgeCount; c++)
      {
        Badges[c].Name = obj.badges[c].name;
        Badges[c].Description = obj.badges[c].description;
        Badges[c].BadgeImage = obj.badges[c].badge;
      }
    }
    
  }
}
