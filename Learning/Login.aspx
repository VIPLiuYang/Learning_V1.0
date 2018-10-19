<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Learning.Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=emulateIE7" />
    <link rel="stylesheet" type="text/css" href="scripts/css/style.css" />
    <link rel="stylesheet" type="text/css" href="scripts/css/skin_/login.css" />
    <title>数字管理系统_用户登录</title>
</head>

<body>
    <div id="container">
        <div id="bd">
            <div id="main">
                <div class="login-box">
                    <div id="logo"></div>
                    <h1></h1>
                    <div id="publicKey" style="display: none;"></div>
                    <div class="input username" id="username">
                        <label for="TexUser">用户名</label>
                        <span></span>
                        <input type="text" id="TexUser" />
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
                            <img alt="" src="viewImg.aspx" onclick="javascript:mmsCheckCode();" id="Img" />
                        </div>
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
                        <input id="LoginBnt" type="button" class="button" value="登录" />
                    </div>
                </div>
            </div>
            <div id="ft">CopyRight&nbsp;2018&nbsp;&nbsp;版权所有&nbsp;&nbsp;</div>
        </div>
    </div>
</body>
<script type="text/javascript" src="scripts/js/jquery.js"></script>
<script type="text/javascript" src="scripts/js/jquery.cookie.js"></script>
<script type="text/javascript" src="scripts/js/jsencrypt.min.js"></script>
<script type="text/javascript" src="scripts/js/jquery.select.js"></script>
<script type="text/javascript">
    $.ajax({
        url: "Login.ashx",
        type: "POST",
        data: { Action: "null" },
        dataType: "text",
        success: function (data) {
            $("#publicKey").html(data);
        },
        error: function (error) {
            alert(error);
        }
    });
</script>

<script type="text/javascript">
    var height = $(window).height() > 445 ? $(window).height() : 445;
    $("#container").height(height);
    var bdheight = ($(window).height() - $('#bd').height()) / 2 - 20;
    $('#bd').css('padding-top', bdheight);
    $(window).resize(function (e) {
        var height = $(window).height() > 445 ? $(window).height() : 445;
        $("#container").height(height);
        var bdheight = ($(window).height() - $('#bd').height()) / 2 - 20;
        $('#bd').css('padding-top', bdheight);
    });
    $('select').select();


    // 使用jsencrypt类库加密js方法，
    function encryptRequest(reqUrl, data, publicKey) {
        var encrypt = new JSEncrypt();
        encrypt.setPublicKey(publicKey);
        // ajax请求发送的数据对象
        var sendData = new Object();
        // 将data数组赋给ajax对象
        for (var key in data) {
            sendData[key] = encrypt.encrypt(data[key]);
        }
        sendData["Action"] = "Login";
        var prikey = "";
        var uncrypted = 0;
        $.ajax({
            url: reqUrl,
            type: "post",
            //async:false,
            data: { Action: sendData["Action"], UserName: sendData["LgName"], PassWord: sendData["Pwd"], TxtCode: sendData["Code"] },
            //data:sendData,
            dataType: "text",
            // contentType: "text/xml;charset=UTF-8",
            success: function (data, textStatus) {
                if (data == "001") {
                    window.location.href = "Index.aspx";
                }
                else if (data == "002") {
                    alert("账号或密码错误,或者被停用，请联系管理员。");
                    //$("#btnLogin").bind("click", btnLoginFun);
                    //$("#btnLogin").removeAttr("disabled");
                } else if (data == "003") {
                    alert("用户名不能为空!");
                    //$("#btnLogin").bind("click", btnLoginFun);
                    //$("#btnLogin").removeAttr("disabled");
                } else if (data == "004") {
                    alert("验证码错误!");
                    //$("#btnLogin").bind("click", btnLoginFun);
                    //$("#btnLogin").removeAttr("disabled");
                } else {
                    mmsCheckCode();
                    alert(data);
                    //$("#btnLogin").bind("click", btnLoginFun);
                    //$("#btnLogin").removeAttr("disabled");
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(XMLHttpRequest.status);
                alert(XMLHttpRequest.readyState);
                alert(textStatus);
                alert(errorThrown);
            }
        });
    }

    //验证码单击事件
    function mmsCheckCode() {
        var myimg = document.getElementById("Img");
        myimg.src = 'viewImg.aspx?abc=' + Math.random();
        $("#valiDate").val('');
    }

    //页面初始化
    $(function () {
        bntLoginFun = function () {
            $("#LoginBnt").unbind();
            $("#LoginBnt").attr("disabled", "disabled");

            var data = [];
            data["LgName"] = $("#TexUser").val();
            data["Pwd"] = $("#TexPwd").val();
            data["Code"] = $("#valiDate").val();

            var pkey = $("#publicKey").html();
            encryptRequest("Login.ashx", data, pkey);
        }

        //登录事件
        $("#LoginBnt").click(function () {
            bntLoginFun();
        });

        //当按下键盘上的回车键时，提交登录表单
        $(document).keyup(function (event) {
            var data = [];
            data["LgName"] = $("#TexUser").val();
            data["Pwd"] = $("#TexPwd").val();
            data["Code"] = $("#valiDate").val();//ace
            data["IsCookies"] = "0";
            if (event.keyCode == 13) {
                if (data["LgName"] != "" && data["Pwd"] != "" && data["Code"] != "") {
                    var pkey = $("#publicKey").html();
                    encryptRequest("Login.ashx", data, pkey);
                } else {
                    if (data["LgName"] == "") { alert("用户名不允许为空！"); }
                    if (data["Pwd"] == "") { alert("请填写密码！"); }
                    if (data["Code"] == "") { alert("请填写验证码！"); }
                }
            }
        });
    });
</script>
</html>
