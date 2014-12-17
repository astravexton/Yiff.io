<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Uploadfile" %>
<!DOCTYPE html>
<html>
    <head>
        <title><asp:Literal runat="server" ID="AppName"></asp:Literal></title>
        <link rel="icon" type="image/png" href="content/favicon.png">
        <link rel="stylesheet" href="content/site.css" />
        <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">
    </head>
    <body>
		<div id="floatover">
			<div id="upload-panel">
				<form runat="server" ID="formUpload">
					<asp:FileUpload runat="server" ID="formUploadFile" />
					<asp:Button runat="server" ID="formUploadButton" Text="Upload!" OnClick="formUploadButton_Click" />
					<button id="formUploadClose">&times;</button>
				</form>
			</div>
		</div>
        <div id="floater">
            <ul>
                <li>
                    <a href="/">
                        <img src="content/logo.png" />
                    </a>
                </li>
                <li id="action-random" title="Next random image">
                    <i class="fa fa-random"></i>
                </li>
                <li id="action-timer" title="'Hands-free' timer mode" style="opacity: 0.5;">
                    <i class="fa fa-clock-o"></i>
                </li>
                <li id="action-resize" title="Fit image vertically to window">
                    <i class="fa fa-arrows-v"></i>
                </li>
                <li id="action-link" title="Direct link to image">
                    <i class="fa fa-link"></i>
                </li>
                <li id="action-edit" title="Edit image with Pixlr">
                    <i class="fa fa-edit"></i>
                </li>
				<li id="action-upload" title="Upload an image">
                    <i class="fa fa-upload"></i>
                </li>
            </ul>
        </div>
        <div id="gaffa">
            <asp:Image runat="server" ImageUrl="null" ID="viewerimage" />
        </div>
        <script src="//code.jquery.com/jquery-1.11.0.min.js"></script>
        <script src="scripts/site.js"></script>
        <script src="scripts/cookies.js"></script>
    </body>
</html>