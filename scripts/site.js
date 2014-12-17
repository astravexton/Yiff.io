$(document).ready(function ()
{
	loadCookies();
	$("#action-random").click(function ()
	{
		location.reload();
	});
	$("#action-timer").click(function ()
	{
		alert("Feature not implemented... yet!")
	})
	$("#action-resize").click(function ()
	{
		var windowHeight = $(window).height();
		var current = docCookies.getItem("action-resize");
		if (current == "true")
		{
			$("#gaffa").css("height", "auto");
			$("#action-resize").css("color", "inerit");
			docCookies.removeItem("action-resize");
			docCookies.setItem("action-resize", false);
		} else if (current == "false")
		{
			$("#gaffa").css("height", windowHeight + "px");
			$("#action-resize").css("color", "#26FF00");
			docCookies.removeItem("action-resize");
			docCookies.setItem("action-resize", true);
		} else
		{
			$("#gaffa").css("height", windowHeight + "px");
			$("#action-resize").css("color", "#26FF00");
			docCookies.setItem("action-resize", true);
		}
	});
	$("#action-link").click(function ()
	{
		window.location = $("#viewerimage").prop("src");
	});
	$("#action-edit").click(function ()
	{
		window.location = "http://pixlr.com/editor?" + "image=" + $("#viewerimage").prop("src") + "&referrer=" + window.location.hostname + "&exit=http://yiff.io/";
	});
	$("#action-upload").click(function ()
	{
		$("#floatover").fadeIn("slow", function ()
		{
			// Animation complete
		});
	});

	$("#viewerimage").click(function ()
	{
		location.reload();
	});

	$("#formUploadClose").click(function ()
	{
		$("#floatover").fadeOut("slow", function ()
		{
			// Animation complete
		});
		return false;
	});
});

function loadCookies()
{
	actionTimer();
	actionResize();
	function actionTimer()
	{
		var current = docCookies.getItem("action-timer");
	}
	function actionResize()
	{
		var windowHeight = $(window).height();
		var current = docCookies.getItem("action-resize");
		if (current == "false")
		{
			$("#gaffa").css("height", "auto");
			$("#action-resize").css("color", "inerit");
		} else if (current == "true")
		{
			$("#gaffa").css("height", windowHeight + "px");
			$("#action-resize").css("color", "#26FF00");
		} else
		{
			$("#gaffa").css("height", "auto");
			$("#action-resize").css("color", "inerit");
		}
	}
}
