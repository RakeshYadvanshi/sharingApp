using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml;
using HtmlAgilityPack;
using System.Xml.Linq;
using System.Web.Script.Serialization;

namespace SharingApp.App_Code
{
    public class Collecter
    {
        public void ProcessChenal9()
        {



        }


    }

    class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string[] hashTags { get; set; }
        public string[] atTags { get; set; }
        public DateTime DownloadDate { get; set; }
        public string Provider { get; set; }

       
    }

    class DataBase
    {
        private List<Post> _Posts;

        public List<Post> Posts
        {
            get
            {
                using (StreamReader sReader = new StreamReader("/db/MyPostCollection.json"))
                {
                    JavaScriptSerializer j = new JavaScriptSerializer();
                    _Posts = j.Deserialize<List<Post>>(sReader.ReadToEnd());
                }
                return _Posts;

            }
            set
            {
                _Posts = value;
                JavaScriptSerializer jss = new JavaScriptSerializer();
                string Dbstring = jss.Serialize(value);

                using (StreamWriter sw = new StreamWriter("/db/MyPostCollection.json"))
                {
                    sw.WriteLine(Dbstring);

                }
            }
        }


        public void Add(Post post)
        {
            _Posts.Add(post);
           
        }

        public void Remove(Post post)
        {
            _Posts.Remove(post);
        }



    }
}
