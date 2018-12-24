<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SysUser.aspx.cs" Inherits="Learning.Web.SystemSetup.SysUser" %> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<<<<<<< HEAD
<head runat="server">

=======
<head id="Head1" runat="server"> 
>>>>>>> da1dc59ec00021b2fcdb61c1154b8d352fa695e3
<meta http-equiv="X-UA-Compatible" content="IE=emulateIE7" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" type="text/css" href="../../scripts/css/style.css" />
<link rel="stylesheet" type="text/css" href="../../scripts/css/WdatePicker.css" />
<link rel="stylesheet" type="text/css" href="../../scripts/css/skin_/table.css" />
<link rel="stylesheet" type="text/css" href="../../scripts/css/jquery.grid.css" />


<title>表格</title>
</head>

<body>
<div id="container">
	<div id="hd"></div>
    <div id="bd">
    	<div id="main">
        	<div class="search-box ue-clear">
<<<<<<< HEAD
            	<div class="search-area"> 
                 <%--   <div class="kv-item ue-clear">
=======
            	<div class="search-area">
                    <div class="kv-item ue-clear">
                        <label>选择时间：</label>
                        <div class="kv-item-content ue-clear">
                            <span class="choose">
                                <span class="checkboxouter">
                                    <input type="radio" name="time" />
                                    <span class="radio"></span>
                                </span>
                                <span class="text">全部</span>
                            </span>
                            <span class="choose">
                                <span class="checkboxouter">
                                    <input type="radio" name="time" />
                                    <span class="radio"></span>
                                </span>
                                <span class="text">近3天</span>
                            </span>
                            <span class="choose">
                                <span class="checkboxouter">
                                    <input type="radio" name="time" />
                                    <span class="radio"></span>
                                </span>
                                <span class="text">近一周</span>
                            </span>
                            <span class="choose">
                                <span class="checkboxouter">
                                    <input type="radio" name="time" />
                                    <span class="radio"></span>
                                </span>
                                <span class="text">近一月</span>
                            </span>
                            <span class="choose">
                                <span class="checkboxouter">
                                    <input type="radio" name="time" data-define="define" />
                                    <span class="radio"></span>
                                </span>
                                <span class="text">自定义</span>
                            </span>
                            <span class="define-input">
                            	<input type="text" placeholder="开始时间" />
                                <span class="division"></span>
                                <input type="text" placeholder="结束时间" />
                            </span>
                        </div>
                    </div>
                    <div class="kv-item ue-clear">
>>>>>>> da1dc59ec00021b2fcdb61c1154b8d352fa695e3
                        <label>选择类型:</label>
                        <div class="kv-item-content">
                            <select>
                                <option>全部</option>
                                <option>全部</option>
                                <option>全部</option>
                            </select>
                        </div>
<<<<<<< HEAD
                    </div>--%>
                </div>
                <div class="search-button">
                	<input class="button" type="button" value="搜索一下" onclick="Search()" />
=======
                    </div>
                </div>
                <div class="search-button">
                	<input class="button" type="button" value="搜索一下" />
>>>>>>> da1dc59ec00021b2fcdb61c1154b8d352fa695e3
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
<script type="text/javascript">
    $('select').select();
<<<<<<< HEAD

    function Search() {
         


        var params = '{"PageIndex":"' + PageIndex + '","PageSize":"' + PageSize + '","txtname":"' + txtname + '","ustat":"' + ustat + '","cotycode":"' + cotycode + '","schid":"' + txtschid + '","aprovserch":"' + aprovserch + '","acityserch":"' + acityserch + '"}';
        $.ajax({
            type: "POST",  //请求方式
            url: "SchInfo.aspx/page",  //请求路径：页面/方法名字
=======
    var head = [{
        label: 'ID',
        width: 100,
        sortable: 'default',
        name: 'id'
    }, {
        label: '用户名',
        width: 150,
        sortable: 'default',
        name: 'name'
    }, {
        label: '昵称',
        width: 150
    }, {
        label: '籍贯',
        width: 150
    }, {
        label: '毕业院校',
        minWidth: 200
    }, {
        label: '出生日期',
        width: 120
    }, {
        label: '是否审核',
        width: 100
    }];

    var oper = [{
        label: '删除', onclick: function () {
            alert('删除');
        }
    }, {
        label: '编辑', onclick: function () {
            alert('编辑')
        }
    }]
    var tbody = [
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201302", "uimaker", "小牛", "山东济南", "山东大学", "1989-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201302", "uimaker", "小牛", "山东济南", "山东大学", "1989-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201302", "uimaker", "小牛", "山东济南", "山东大学", "1989-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201302", "uimaker", "小牛", "山东济南", "山东大学", "1989-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper],
					["201302", "uimaker", "小牛", "山东济南", "山东大学", "1989-10-18", "已审核", oper],
					["201301", "admin", "熊猫王子", "江苏南京", "南京林业大学", "1982-10-18", "已审核", oper]]


    $('.grid').Grid({
        thead: head,
        tbody: null,
        height: 400,
        checkbox: {
            single: true
        },
        operator: {
            type: "normal",
            width: 100
        },
        sortCallBack: function (name, index, type) {
            alert(name + "," + index + ',' + type);
        }

    });

    $('.grid').Grid('addLoading');

    /// 模拟异步
    setTimeout(function () {
        $('.grid').Grid('setData', tbody, head);
    }, 2000)


    $('.pagination').pagination(100, {
        callback: function (page) {
            alert(page);
        },
        display_msg: false
    });

    $('.search-box input[type=radio]').click(function (e) {
        if ($(this).prop('checked')) {
            if ($(this).attr('data-define') === 'define') {
                $('.define-input').show();
            } else {
                $('.define-input').hide();
            }
        }
    });



    function search() {
        var PageIndex = 1;
        var PageSize = 10;
        var pageCount = 1;
        var uname = $('#txtname').val();
        var ustat = $('#ustat').val(); 
        var params = '{"PageIndex":"' + PageIndex + '","PageSize":"' + PageSize + '","uname":"' + uname + '","ustat":"' + ustat + '"}';
        $.ajax({
            type: "POST",  //请求方式
            url: "SysUser.aspx/page",  //请求路径：页面/方法名字
>>>>>>> da1dc59ec00021b2fcdb61c1154b8d352fa695e3
            data: params,     //参数
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.d.code == "expire") {
<<<<<<< HEAD
                    alert(data.d.msg);
=======
>>>>>>> da1dc59ec00021b2fcdb61c1154b8d352fa695e3
                    window.location.href = "../../LoginExc.aspx";
                }
                else if (data.d.code == "error") {
                    alert(data.d.msg);
                }
                else {
<<<<<<< HEAD
                    dodata(eval('(' + data.d.data + ')'));
=======
                    alert(eval('(' + data.d.data + ')'));
>>>>>>> da1dc59ec00021b2fcdb61c1154b8d352fa695e3
                }
            },
            error: function (obj, msg, e) {
            }
        });
    }
<<<<<<< HEAD

	var head = [{
				label: 'ID',
				width: 100,
				sortable: 'default',
				name: 'id'	
			},{
				label:'用户名',
				width: 150,
				sortable: 'default',
				name:'name'	
			},{
				label:'昵称',
				width:150	
			},{
				label: '籍贯',
				width: 150	
			},{
				label: '毕业院校',
				minWidth: 200	
			},{
				label: '出生日期',
				width: 120	
			},{
				label: '是否审核',
				width:100	
			}];
			
	var oper = [{label:'删除',onclick:function(){
						alert('删除');
				}},{label:'编辑',onclick: function(){
					alert('编辑')	
				}}]
	var tbody = [
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper], 
					["201302","uimaker","小牛","山东济南","山东大学","1989-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper], 
					["201302","uimaker","小牛","山东济南","山东大学","1989-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper], 
					["201302","uimaker","小牛","山东济南","山东大学","1989-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper], 
					["201302","uimaker","小牛","山东济南","山东大学","1989-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper], 
					["201302","uimaker","小牛","山东济南","山东大学","1989-10-18","已审核",oper],
					["201301","admin","熊猫王子","江苏南京","南京林业大学","1982-10-18","已审核",oper]]
					
					
		$('.grid').Grid({
			thead: head,
			tbody: null,
			height:400,
			checkbox: {
				single:true	
			},
			operator: {
				type : "normal",
				width : 100	
			},
			sortCallBack : function(name,index,type){
				alert(name+","+index+','+type);
			}
			
		});
	
	$('.grid').Grid('addLoading');
	
	/// 模拟异步
	setTimeout(function(){
		$('.grid').Grid('setData',tbody, head);
	},2000)
	
	
	$('.pagination').pagination(100,{
		callback: function(page){
			alert(page);	
		},
		display_msg: false
	});
	
	$('.search-box input[type=radio]').click(function(e) {
        if($(this).prop('checked')){
			if($(this).attr('data-define') === 'define'){
				$('.define-input').show();
			}else{
				$('.define-input').hide();
			}
		}
    });
=======
>>>>>>> da1dc59ec00021b2fcdb61c1154b8d352fa695e3
</script>
</html>

