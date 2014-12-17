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

	protected void formUploadButton_Click(object sender, EventArgs e)
	{
		string AppURL = System.Configuration.ConfigurationManager.AppSettings["AppURL"];
		string RepoUpload = System.Configuration.ConfigurationManager.AppSettings["RepoUpload"];
		string filename = formUploadFile.FileName.ToString();
		formUploadFile.SaveAs(RepoUpload + filename);
		Response.Redirect(AppURL);
	}

	public string CreateFilename(int length)
	{
		//const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
		const string valid = "abcdefghijklmnopqrstuvwxyz1234567890";
		System.Text.StringBuilder res = new System.Text.StringBuilder();
		Random rnd = new Random();
		while (0 < length--)
		{
			res.Append(valid[rnd.Next(valid.Length)]);
		}
		return res.ToString();
	}
}