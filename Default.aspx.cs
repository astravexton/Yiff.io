using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Uploadfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AppName.Text = System.Configuration.ConfigurationManager.AppSettings["AppName"];
        string RepoBackend = System.Configuration.ConfigurationManager.AppSettings["RepoBackend"];
        string RepoFrontend = System.Configuration.ConfigurationManager.AppSettings["RepoFrontend"];

        Random rand = new Random();
        string[] files = Directory.GetFiles(RepoBackend, "*.*", SearchOption.AllDirectories);
        string randomFile = files[rand.Next(files.Length)];
        randomFile = randomFile.Replace(RepoBackend, RepoFrontend).Replace("\\", "/");
        viewerimage.ImageUrl = randomFile;
    }
}