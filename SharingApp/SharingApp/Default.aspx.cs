using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharingApp.App_Code;
using RestSharp;
using System.Net;
using System.Xml;

namespace SharingApp
{
    public partial class Default : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //Collecter collector = new Collecter();
            //collector.ProcessChenal9();

            using (WebClient w = new WebClient())
            {
                string DownloadData = w.DownloadString("https://channel9.msdn.com/Feeds/RSS");
                if (!string.IsNullOrWhiteSpace(DownloadData))
                {
                    string str = string.Empty;
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(DownloadData);
                    var Document = xml.DocumentElement;
                    var EntryList = Document.ChildNodes[0].ChildNodes;
                    foreach (XmlNode item in EntryList)
                    {
                        switch (item.Name)
                        {
                            case "item":
                                Post p = new Post() {
                                    Id = Guid.NewGuid(),
                                    DownloadDate = DateTime.Now,
                                    Link = item.InnerText.ToString(),
                                    Provider = "Chennal9",
                                    atTags = new string[] { "ch9" },
                                    Title = item.InnerText,
                                    hashTags = new string[] { item.InnerText.ToString() }
                                };
                                break;
                        }

                    }
                    json.InnerHtml = str;

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            TwitterApi t = new TwitterApi();
            json.InnerText = t.GetFollowerIds();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {

                TwitterApi t = new TwitterApi();
                json.InnerText = t.PostData("");

            }
            catch (Exception ex)
            {
                json.InnerText = ex.Message;


            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}