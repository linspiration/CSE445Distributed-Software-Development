<%@ Application Language="C#" %>
<%@ Import Namespace="A5WebSite" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.IO" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        string userName = "";
        Application["UserName"] = userName;
        AuthConfig.RegisterOpenAuth();


        Application["StartTime"] = System.DateTime.Now;
        StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "/TotalSessions.txt");
        int count = int.Parse(sr.ReadLine());
        Application["SessionUsedCount"] = count;
        sr.Close();
    }
    
    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        int count = (int)Application["SessionUsedCount"];
        count += 1;
        Application["SessionUsedCount"] = count;
        string filePath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "/TotalSessions.txt";
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
        fs.SetLength(0);
        fs.Close();
        StreamWriter srw = new StreamWriter(filePath);
        srw.WriteLine(count);
        srw.Close();
    }
</script>
