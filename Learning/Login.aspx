﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Learning.Login" %> 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta http-equiv="X-UA-Compatible" content="IE=emulateIE7" />
<link rel="stylesheet" type="text/css" href="scripts/css/style.css" />
<link rel="stylesheet" type="text/css" href="scripts/css/skin_/login.css" />
<script type="text/javascript" src="scripts/js/jquery.js"></script> 
<script type="text/javascript" src="scripts/js/jquery.select.js"></script>
<title>数字管理系统_用户登录</title>
</head>

<body>
<div id="container">
    <div id="bd">
    	<div id="main">
        	<div class="login-box">
                <div id="logo"></div>
                <h1></h1>
                <div class="input username" id="username">
                    <label for="TexUser">用户名</label>
                    <span></span>
                    <input type="text" id="userName" />
                </div>
                <div class="input psw" id="psw">
                    <label for="password">密&nbsp;&nbsp;&nbsp;&nbsp;码</label>
                    <span></span>
                    <input type="password" id="TexPwd" />
                </div>
                <div class="input validate" id="validate">
                    <label for="valiDate">验证码</label>
                    <input type="text" id="valiDate" />
                    <div class="value">
                        <img alt="" src="viewImg.aspx" onclick="javascript:mmsCheckCode();" id="Img" /></div>
                </div>
                <div class="styleArea">
                    <div class="styleWrap">
                        <select name="style">
                            <option value="默认风格">默认风格</option>
                            <option value="红色风格">红色风格</option>
                            <option value="绿色风格">绿色风格</option>
                        </select>
                    </div>
                </div>
                <div id="btn" class="loginButton">
                    <input id="LoginBnt" type="button" class="button" value="登录"   />
                </div>
            </div>
        </div>
        <div id="ft">CopyRight&nbsp;2018&nbsp;&nbsp;版权所有&nbsp;&nbsp;</div>
    </div>
   
</div>
</body>
<script type="text/javascript">
	var height = $(window).height() > 445 ? $(window).height() : 445;
	$("#container").height(height);
	var bdheight = ($(window).height() - $('#bd').height()) / 2 - 20;
	$('#bd').css('padding-top', bdheight);
	$(window).resize(function(e) {
        var height = $(window).height() > 445 ? $(window).height() : 445;
		$("#container").height(height);
		var bdheight = ($(window).height() - $('#bd').height()) / 2 - 20;
		$('#bd').css('padding-top', bdheight);
    });
	$('select').select();
    //验证码单击事件
	function mmsCheckCode() {
	    var myimg = document.getElementById("Img");
	    myimg.src = 'viewImg.aspx?abc=' + Math.random();
	    $("#valiDate").val('');
	}
    //页面初始化
	$(function () {
	    bntLoginFun = function () {
	        $("LoginBnt").unbind();
	        $("LoginBnt").attr("disabled", "disabled");

	        var data = [];
	        data["LgName"] = $("TexUser").val;
            data["Pwd"]=$("TexPwd").val;
	    }

	    $("LoginBnt").click(function () {

	    });
	});
	 
</script>
</html>
