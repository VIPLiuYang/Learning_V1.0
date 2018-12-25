<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SysUser.aspx.cs" Inherits="Learning.Web.SystemSetup.SysUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=emulateIE7" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="../../scripts/css/style.css" />
    <link rel="stylesheet" type="text/css" href="../../scripts/css/WdatePicker.css" />
    <link rel="stylesheet" type="text/css" href="../../scripts/css/skin_/table.css" />
    <link rel="stylesheet" type="text/css" href="../../scripts/css/jquery.grid.css" />
    <link type="text/css" href="../../scripts/js/jsgrid-1.5.3/jsgrid-theme.min.css" rel="stylesheet" />
    <link type="text/css" href="../../scripts/js/jsgrid-1.5.3/jsgrid.min.css" rel="stylesheet" />
    <title>表格</title>
</head>
<body>
    <div id="container">
        <div id="hd"></div>
        <div id="bd">
            <div id="main">
                <div class="search-box ue-clear">

                    <div class="search-button">
                        <input class="button" type="button" value="查询" onclick="Search()" />
                    </div>
                </div>

                <div class="table">
                    <div class="opt ue-clear">
                        <span class="sortarea">
                            <span class="sort">
                                <label>排序：</label>
                                <span class="name">
                                    <i class="icon"></i>
                                    <span class="text">名称</span>
                                </span>
                            </span>

                            <i class="list"></i>
                            <i class="card"></i>
                        </span>
                        <span class="optarea">
                            <a href="javascript:;" class="add">
                                <i class="icon"></i>
                                <span class="text">添加</span>
                            </a>
                            <a href="javascript:;" class="delete">
                                <i class="icon"></i>
                                <span class="text">删除</span>
                            </a>

                            <a href="javascript:;" class="statistics">
                                <i class="icon"></i>
                                <span class="text">统计</span>
                            </a>

                            <a href="javascript:;" class="config">
                                <i class="icon"></i>
                                <span class="text">配置</span>
                            </a>
                        </span>
                    </div>

                    <div class="grid"></div>

                    <div class="pagination"></div>
                </div>
            </div>
        </div>
    </div>
</body>
<script type="text/javascript" src="../../scripts/js/jquery.js"></script>
<script type="text/javascript" src="../../scripts/js/global.js"></script>
<script type="text/javascript" src="../../scripts/js/jquery.select.js"></script>
<script type="text/javascript" src="../../scripts/js/core.js"></script>
<script type="text/javascript" src="../../scripts/js/jquery.pagination.js"></script>
<script type="text/javascript" src="../../scripts/js/jquery.grid.js"></script>
<script type="text/javascript" src="../../scripts/js/WdatePicker.js"></script>
<script type="text/javascript" src="../../scripts/js/jsgrid-1.5.3/jsgrid.min.js"></script>
<script type="text/javascript">
    $('select').select();

    $(document).ready(function () { Search(); });//默认执行

    $('.grid').Grid('addLoading'); 
    /// 模拟异步
    setTimeout(function () {
        $('.grid').Grid('setData', tbody, head);
    }, 1000)

    $('.pagination').pagination(100, {
        callback: function (page) {
            alert(page);
        },
        display_msg: false
    });

  

    var clients = [];//初始化用户信息

    ///查询
    function Search() {
        var PageIndex = 1;
        var PageSize = 10;
        var pageCount = 1;
        var uname = $('#txtname').val();
        var ustat = $('#ustat').val();
        var params = '{"PageIndex":"' + PageIndex + '","PageSize":"' + PageSize + '","uname":"' + uname + '","ustat":"' + ustat + '"}';
        $.ajax({
            type: "POST",  //请求方式
            url: "SysUser.aspx/page",  //请求路径：页面/方法名字
            data: params,     //参数
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.d.code == "expire") {
                    window.location.href = "../../LoginExc.aspx";
                }
                else if (data.d.code == "error") {
                    alert(data.d.msg);
                }
                else { 
                    var obj = eval('(' + data.d.data + ')'); 
                    clients = obj.list; 
                    $(".grid").jsGrid({
                        width: "100%",
                        height: "100%",
                        deleteConfirm: "确认需要删除数据？",
                        //loadMessage: "正在装载数据，请稍候......",
                        noDataContent: "暂无数据",//当所要展示的字段是一个空数组时显示的内容 "Not found",
                        inserting: false, //启动插入 false,
                        editing: false,//启动编辑 false,
                        sorting: true,//启动排序 false,
                        paging: true,//启动分页 false,
                        data: clients,//表格静态数据源 [],
                        editButton:true,
                        controller:{ 
                            loadData: loadData
                        }, //四个控制器，用于增删改查与后台交互形式的定义,详细见扩展1 ,
                        fields: [
                            { name: "UserId",title:"用户ID", type: "text", width: 50 },
                            { name: "UserName",title:"登录名", type: "text", width: 100 },
                            { name: "Name", title: "用户姓名", type: "text", width: 100 },
                            { name: "Status", title: "状态", type: "text", width: 100 },
                            { name: "Email", title: "Email", type: "text", width: 200 },
                             { name: "inssj", title: "注册时间", type: "text", width: 200 },
                              {
                                  type: "control" 
                              }
                                
                        ]//表头字段 [],
                    });
                }
            },
            error: function (obj, msg, e) {
            }
        });
    }


    var loadData = function (e) {

        alert("222");
    };
    function uddate() {
        alert("11")
    }
   

</script>
</html>

