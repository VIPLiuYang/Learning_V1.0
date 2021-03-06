﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nav.aspx.cs" Inherits="Learning.Nav" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="X-UA-Compatible" content="IE=emulateIE7" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="scripts/css/style.css" />
    <link rel="stylesheet" href="scripts/css/zTreeStyle/zTreeStyle.css" type="text/css">
    <link rel="stylesheet" type="text/css" href="scripts/css/skin_/nav.css" />
    <script type="text/javascript" src="scripts/js/jquery.js"></script>
    <script type="text/javascript" src="scripts/js/global.js"></script>
    <title>底部内容页</title>
</head>

<body>
    <div id="container">
        <div id="bd">
            <div class="sidebar">
                <div class="sidebar-bg"></div>
                <i class="sidebar-hide"></i>
                <h2 href="index.html" data-id="00"><a href="javascript:;"> <span>首页</span></a></h2>
                <ul class="nav">
                      <%--<li class="nav-li" href="index.html" data-id="00"><a href="#" class="ue-clear"><i class="home-icon"></i><span class="nav-text">首页</span></a></li>--%> 
                    <%=treestr %>
                </ul>
                <div class="tree-list outwindow">
                    <div class="tree ztree"></div>
                </div>
            </div>
            <div class="main">
                <div class="title">
                    <i class="sidebar-show"></i>
                    <ul class="tab ue-clear">
                    </ul>
                    <i class="tab-more"></i>
                    <i class="tab-close"></i>
                </div>
                <div class="content">
                </div>
            </div>
        </div>
    </div>

    <div class="more-bab-list">
        <ul></ul>
        <div class="opt-panel-ml"></div>
        <div class="opt-panel-mr"></div>
        <div class="opt-panel-bc"></div>
        <div class="opt-panel-br"></div>
        <div class="opt-panel-bl"></div>
    </div>
</body>
<script type="text/javascript" src="scripts/js/nav.js"></script>
<script type="text/javascript" src="scripts/js/Menu.js"></script>
<script type="text/javascript" src="scripts/js/jquery.ztree.core-3.5.js"></script>
<script type="text/javascript">
    var menu = new Menu({
        defaultSelect: $('.sidebar').find('h2[data-id="00"]')
    });

    // 左侧树结构加载
    var setting = {};

    //$('.sidebar h2').click(function (e) {
    //    $('.tree-list').toggleClass('outwindow');
    //    $('.nav').toggleClass('outwindow');
    //});

    $(document).click(function (e) {
        if (!$(e.target).is('.tab-more')) {
            $('.tab-more').removeClass('active');
            $('.more-bab-list').hide();
        }
    });
</script>
</html>
