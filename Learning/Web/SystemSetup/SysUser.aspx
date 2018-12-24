<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SysUser.aspx.cs" Inherits="Learning.Web.SystemSetup.SysUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

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
            	<div class="search-area"> 
                 <%--   <div class="kv-item ue-clear">
                        <label>选择类型:</label>
                        <div class="kv-item-content">
                            <select>
                                <option>全部</option>
                                <option>全部</option>
                                <option>全部</option>
                            </select>
                        </div>
                    </div>--%>
                </div>
                <div class="search-button">
                	<input class="button" type="button" value="搜索一下" onclick="Search()" />
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

    function Search() {
         


        var params = '{"PageIndex":"' + PageIndex + '","PageSize":"' + PageSize + '","txtname":"' + txtname + '","ustat":"' + ustat + '","cotycode":"' + cotycode + '","schid":"' + txtschid + '","aprovserch":"' + aprovserch + '","acityserch":"' + acityserch + '"}';
        $.ajax({
            type: "POST",  //请求方式
            url: "SchInfo.aspx/page",  //请求路径：页面/方法名字
            data: params,     //参数
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.d.code == "expire") {
                    alert(data.d.msg);
                    window.location.href = "../../LoginExc.aspx";
                }
                else if (data.d.code == "error") {
                    alert(data.d.msg);
                }
                else {
                    dodata(eval('(' + data.d.data + ')'));
                }
            },
            error: function (obj, msg, e) {
            }
        });
    }

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
</script>
</html>
