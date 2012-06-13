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
      public string name;
      public string description;
      public string badgeImage;
    };

    private string userName = null;

    // todo: create proper property
    public string Name;
    public string Location;
    public int Endorsements;
    public int BadgeCount;
    
    public List<BadgesStruct> Badges = new List<BadgesStruct>();

    public CoderwallAPI(string _userName)
    {

      string apiCall = "http://coderwall.com/" + _userName + ".json";
      userName = _userName;
      doWebRequest(apiCall);
    }

    private void doWebRequest(string apicall)
    {
      string url = apicall;

      HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apicall);
      request.Method = "GET";
      request.ContentType = "application/json; charset=utf-8";

      HttpWebResponse response = null;

      try
      {
        response = (HttpWebResponse)request.GetResponse();
      }
      catch (WebException Ex)
      {
        if (Ex.Message.Contains("404"))
          throw new NotFoundException("User:" + userName + " or service (http://coderwall.com/) not Found.");
      }

      TextReader temp = new StreamReader(response.GetResponseStream());
      string data = temp.ReadToEnd();

      temp.Close();

      var serializer = new JavaScriptSerializer();
      serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

      dynamic obj = serializer.Deserialize(data, typeof(object));

      Name = obj.name;
      Location = obj.location;
      Endorsements= (int)obj.endorsements;
      BadgeCount = (int)obj.badges.Count;

      for (int c = 0; c < BadgeCount; c++)
      {
        BadgesStruct badge = new BadgesStruct();
        badge.name = obj.badges[c].name;
        badge.description = obj.badges[c].description;

        // this seems to have changed
        badge.badgeImage = obj.badges[c].badge.badge_class_name;

        Badges.Add(badge);
      }
    }
    
  }
}
